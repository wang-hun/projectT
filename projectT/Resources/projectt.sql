/*
 Navicat Premium Dump SQL

 Source Server         : wh
 Source Server Type    : MySQL
 Source Server Version : 80039 (8.0.39)
 Source Host           : localhost:3306
 Source Schema         : projectt

 Target Server Type    : MySQL
 Target Server Version : 80039 (8.0.39)
 File Encoding         : 65001

 Date: 20/08/2024 09:53:51
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for cars
-- ----------------------------
DROP TABLE IF EXISTS `cars`;
CREATE TABLE `cars`  (
  `CarType` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '车型',
  `CarID` int NOT NULL AUTO_INCREMENT COMMENT '车辆编号',
  `CarNumber` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `userid` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`CarID`) USING BTREE,
  INDEX `userid`(`userid` ASC) USING BTREE,
  CONSTRAINT `userid` FOREIGN KEY (`userid`) REFERENCES `users` (`user`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of cars
-- ----------------------------
INSERT INTO `cars` VALUES ('黑色宝马', 1, '鲁B32575', '004');
INSERT INTO `cars` VALUES ('蓝色奔驰', 2, '粤A65357', '004');
INSERT INTO `cars` VALUES ('我的爱马', 3, '京A66666', '004');
INSERT INTO `cars` VALUES ('我的爱马', 4, '京A00461', '005');

-- ----------------------------
-- Table structure for park
-- ----------------------------
DROP TABLE IF EXISTS `park`;
CREATE TABLE `park`  (
  `location` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '位置',
  `parkID` int NOT NULL COMMENT '编号',
  `maxParking` int NULL DEFAULT NULL COMMENT '车位数量',
  `nowParking` int NULL DEFAULT NULL COMMENT '当前停放车位',
  `manageID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '管理员账号',
  `opening` tinyint(1) NULL DEFAULT NULL COMMENT '是否开放',
  `PosX` double(255, 10) NULL DEFAULT NULL COMMENT '纬度',
  `PosY` double(255, 10) NULL DEFAULT NULL COMMENT '经度',
  PRIMARY KEY (`parkID`) USING BTREE,
  INDEX `manageID`(`manageID` ASC) USING BTREE,
  CONSTRAINT `manageID` FOREIGN KEY (`manageID`) REFERENCES `users` (`user`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of park
-- ----------------------------
INSERT INTO `park` VALUES ('命莲寺地下', 1, 1000, 1, '002', 0, 32.0433360000, 120.8087170000);
INSERT INTO `park` VALUES ('阳光赛马场', 2, 2000, 0, '002', 0, 32.0195748161, 120.8588790894);

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `passcode` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '密码',
  `telnum` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '电话',
  `name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '姓名',
  `identity` int NOT NULL COMMENT '身份类型',
  `sub` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `user` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '账号\r\n',
  `qqID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT 'qq号',
  PRIMARY KEY (`sub`) USING BTREE,
  INDEX `user`(`user` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 9 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('001', '123456', '张三', 0, 1, '001', NULL);
INSERT INTO `users` VALUES ('002', '654321', '李四', 1, 2, '002', NULL);
INSERT INTO `users` VALUES ('003', '1234567', '王五', 2, 3, '003', '1008611');
INSERT INTO `users` VALUES ('000', '13663532518', '李帅', 0, 4, '004', '3013629683');
INSERT INTO `users` VALUES ('999', '18013980699', '孙瑞阳', 0, 5, '005', '1790789430');
INSERT INTO `users` VALUES ('000', '17626516963', '于苏誉', 0, 6, '006', NULL);

SET FOREIGN_KEY_CHECKS = 1;
