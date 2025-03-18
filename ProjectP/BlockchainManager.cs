namespace ProjectP
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using System.Runtime.CompilerServices;

    public struct Block
    {
        /// <summary>
        /// 区块位置
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 区块生成时间戳
        /// </summary>
        public string TimeStamp { get; set; }
        /// <summary>
        /// 停车位置
        /// </summary>
        public string local { get; set; }
        /// <summary>
        /// 区块 SHA-256 散列值
        /// </summary>
        public string Hash { get; set; }
        /// <summary>
        /// 前一个区块 SHA-256 散列值
        /// </summary>
        public string PrevHash { get; set; }
    }
    

    public static class BlockchainManager
    {
        #region 工具方法

        public static bool IsNullOrEmpty(this string str)
        {
           return string.IsNullOrEmpty(str);
        }
        #endregion
        public static List<Block> _blockChain;
        public static string SavePath;
        public static void startBlockChain(string path)
        {
            SavePath = path;
            LoadBlockchainFromDirectory();
            if (_blockChain.Count == 0)
            {
                var firstBlock = new Block
                {
                    Index = 0,
                    TimeStamp = CalculateCurrentTimeUTC(),
                    local="",
                    PrevHash="",
                 
                };
                firstBlock.Hash= CalculateHash(firstBlock);
                SaveBlockToFile(firstBlock);
                _blockChain.Add(firstBlock);
            }
        }
        /// <summary>
        /// 查询块方法
        /// </summary>
        /// <param name="targetHash"></param>
        /// <returns></returns>
        public static (string local, bool isValid) QueryBlockByHash(string targetHash)
        {
            // 在区块链中查找目标区块
            Block currentBlock = _blockChain.FirstOrDefault(b => b.Hash == targetHash);

            if (currentBlock.Hash.IsNullOrEmpty())
                return ("", false);

            // 查找前序区块
            Block previousBlock = _blockChain.FirstOrDefault(b => b.Index == currentBlock.Index - 1);

            // 执行区块验证
            bool isValid = IsBlockValid(
                newBlock: currentBlock,
                oldBlock: previousBlock
            );

            // 根据验证结果返回对应值
            return isValid ? (currentBlock.local, true) : ("", false);
        }

        /// <summary>
        /// 创建新块
        /// </summary>
        /// <param name="local"></param>
        /// <returns>哈希值</returns>
        public static string creatBlock(string local)
        {
            var lastIndex= _blockChain.Count - 1;
            var newBlock = GenerateBlock(_blockChain[lastIndex], local);
            SaveBlockToFile(newBlock);
            _blockChain.Add(newBlock);
            return newBlock.Hash;
        }
        // 存储单个 Block 到 JSON 文件
        private static void SaveBlockToFile(Block block)
        {
            // 确保目录存在
            Directory.CreateDirectory(SavePath);

            // 序列化时保留所有属性
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(block, settings);
            string fileName = $"P_{block.Hash}.json";
            string fullPath = Path.Combine(SavePath, fileName);

            File.WriteAllText(fullPath, json);
        }

        // 批量加载 JSON 文件到区块链列表
        private static void LoadBlockchainFromDirectory()
        {
            _blockChain = new List<Block>();

            if (!Directory.Exists(SavePath)) return;

            var settings = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error,
                NullValueHandling = NullValueHandling.Ignore
            };

            foreach (var file in Directory.GetFiles(SavePath, "P_*.json"))
            {
                try
                {
                    string json = File.ReadAllText(file);
                    Block block = JsonConvert.DeserializeObject<Block>(json, settings);
                    _blockChain.Add(block);
                }
                catch (JsonException ex)
                {
                    // 处理格式错误的文件
                    Console.WriteLine($"文件 {Path.GetFileName(file)} 解析失败: {ex.Message}");
                }
            }

            // 按区块索引排序
            _blockChain.Sort((a, b) => a.Index.CompareTo(b.Index));
        }
        /// <summary>
        /// 计算区块 HASH 值
        /// </summary>
        /// <param name="block">区块实例</param>
        /// <returns>计算完成的区块散列值</returns>
        private static string CalculateHash(Block block)
        {
            string calculationStr = $"{block.Index}{block.TimeStamp}{block.local}{block.PrevHash}";
            SHA256 sha256Generator = SHA256.Create();
            byte[] sha256HashBytes = sha256Generator.ComputeHash(Encoding.UTF8.GetBytes(calculationStr));
            StringBuilder sha256StrBuilder = new StringBuilder();
            foreach (byte @byte in sha256HashBytes)
            {
                sha256StrBuilder.Append(@byte.ToString("x2"));
            }
            return sha256StrBuilder.ToString();
        }
        /// <summary>
        /// 生成新的区块
        /// </summary>
        /// <param name="oldBlock">旧的区块数据</param>
        /// <returns>新的区块</returns>
        private static Block GenerateBlock(Block oldBlock, string local)
        {
            Block newBlock = new Block()
            {
                Index = oldBlock.Index + 1,
                TimeStamp = CalculateCurrentTimeUTC(),
                local = local,
                PrevHash = oldBlock.Hash
            };
            newBlock.Hash = CalculateHash(newBlock);
            return newBlock;
        }

        /// <summary>
        /// 计算当前时间的 UTC 表示格式
        /// </summary>
        /// <returns>UTC 时间字符串</returns>
        private static string CalculateCurrentTimeUTC()
        {
            DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime nowTime = DateTime.Now;
            long unixTime = (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero);
            return unixTime.ToString();
        }
        /// <summary>
        /// 检验区块是否有效
        /// </summary>
        /// <param name="newBlock">新生成的区块数据</param>
        /// <param name="oldBlock">旧的区块数据</param>
        /// <returns>有效返回 TRUE，无效返回 FALSE</returns>
        private static bool IsBlockValid(Block newBlock, Block oldBlock)
        {
            if (oldBlock.Index + 1 != newBlock.Index) return false;
            if (oldBlock.Hash != newBlock.PrevHash) return false;
            if (CalculateHash(newBlock) != newBlock.Hash) return false;
            return true;
        }
        /// <summary>
        /// 如果新的区块链比当前区块链更新，则切换当前区块链为最新区块链
        /// </summary>
        /// <param name="newBlockChain">新的区块链</param>
        private static void SwitchChain(List<Block> newBlockChain)
        {
            if (newBlockChain.Count > _blockChain.Count)
            {
                _blockChain = newBlockChain;
            }
        }

    }
}
