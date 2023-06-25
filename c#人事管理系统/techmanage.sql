/*
 Navicat Premium Data Transfer

 Source Server         : techmanage
 Source Server Type    : MySQL
 Source Server Version : 50650
 Source Host           : 49.232.138.196:3306
 Source Schema         : techmanage

 Target Server Type    : MySQL
 Target Server Version : 50650
 File Encoding         : 65001

 Date: 21/06/2021 00:34:13
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for course
-- ----------------------------
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course`  (
  `courseid` int(11) NOT NULL,
  `coursename` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `coursetime` int(11) NULL DEFAULT NULL,
  `credithour` int(255) NULL DEFAULT NULL,
  `character` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`courseid`) USING BTREE,
  INDEX `coursename`(`coursename`(191)) USING BTREE,
  INDEX `coursetime`(`coursetime`) USING BTREE,
  INDEX `credithour`(`credithour`) USING BTREE,
  INDEX `character`(`character`(191)) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO `course` VALUES (100, 'c语言', 56, 3, '必修');
INSERT INTO `course` VALUES (101, 'c++课程设计', 56, 3, '必修');
INSERT INTO `course` VALUES (102, 'python课程设计', 28, 1, '选修');
INSERT INTO `course` VALUES (103, '电子商务', 36, 2, '选修');
INSERT INTO `course` VALUES (104, 'Java程序设计', 56, 3, '必修');
INSERT INTO `course` VALUES (105, '软件测试', 28, 1, '选修');
INSERT INTO `course` VALUES (106, '操作系统', 56, 3, '必修');
INSERT INTO `course` VALUES (107, '汇编语言', 36, 2, '选修');
INSERT INTO `course` VALUES (108, '计算机原理', 56, 3, '必修');
INSERT INTO `course` VALUES (109, '数据结构', 56, 3, '必修');
INSERT INTO `course` VALUES (110, '计算机网络', 48, 3, '必修');
INSERT INTO `course` VALUES (111, '软件需求', 36, 2, '选修');

-- ----------------------------
-- Table structure for studycondition
-- ----------------------------
DROP TABLE IF EXISTS `studycondition`;
CREATE TABLE `studycondition`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `teacherid` int(11) NULL DEFAULT NULL,
  `direction` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `condition` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `patent` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `paper` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of studycondition
-- ----------------------------
INSERT INTO `studycondition` VALUES (1, 1005, '人工智能', '国家自然基金', '专利1', '论文1');
INSERT INTO `studycondition` VALUES (2, 1005, '人工智能', '省级基金', '专利2', '论文2');
INSERT INTO `studycondition` VALUES (3, 1008, '数据挖掘', '国家自然基金', '专利3', '论文3');
INSERT INTO `studycondition` VALUES (4, 1008, '数据挖掘', '省级基金', '专利4', '论文4');
INSERT INTO `studycondition` VALUES (5, 1001, '智能软件', '省级基金', '专利5', '论文5');
INSERT INTO `studycondition` VALUES (6, 1009, '大数据', '省级基金', '专利6', '论文6');
INSERT INTO `studycondition` VALUES (9, 1002, '大数据', '省级基金', '专利7', '论文7');

-- ----------------------------
-- Table structure for teacher
-- ----------------------------
DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher`  (
  `teacherid` int(11) NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `sex` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `age` int(11) NULL DEFAULT NULL,
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`teacherid`) USING BTREE,
  INDEX `name`(`name`(191)) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of teacher
-- ----------------------------
INSERT INTO `teacher` VALUES (1001, '占皓月', '男', 35, '研究员');
INSERT INTO `teacher` VALUES (1002, '伊忆远', '男', 40, '副教授');
INSERT INTO `teacher` VALUES (1003, '阳飞兰', '女', 45, '副教授');
INSERT INTO `teacher` VALUES (1004, '素书白', '女', 50, '副教授');
INSERT INTO `teacher` VALUES (1005, '玄悦', '男', 41, '教授');
INSERT INTO `teacher` VALUES (1006, '殷千秋', '男', 35, '讲师');
INSERT INTO `teacher` VALUES (1007, '天春雪', '女', 36, '讲师');
INSERT INTO `teacher` VALUES (1008, '仝从珊', '女', 55, '教授');
INSERT INTO `teacher` VALUES (1009, '本秋柔', '女', 40, '研究员');
INSERT INTO `teacher` VALUES (1010, '戴泽民', '男', 34, '讲师');

-- ----------------------------
-- Table structure for teacherinfo
-- ----------------------------
DROP TABLE IF EXISTS `teacherinfo`;
CREATE TABLE `teacherinfo`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `teacherid` int(11) NULL DEFAULT NULL,
  `teachname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `courseid` int(11) NULL DEFAULT NULL,
  `coursename` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `coursetime` int(11) NULL DEFAULT NULL,
  `credithour` int(11) NULL DEFAULT NULL,
  `character` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `fk1`(`teacherid`) USING BTREE,
  INDEX `fk2`(`courseid`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 17 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of teacherinfo
-- ----------------------------
INSERT INTO `teacherinfo` VALUES (1, 1002, '伊忆远', 100, 'c语言', 56, 3, '必修');
INSERT INTO `teacherinfo` VALUES (2, 1010, '戴泽民', 101, 'c++课程设计', 56, 3, '必修');
INSERT INTO `teacherinfo` VALUES (3, 1003, '阳飞兰', 102, 'python课程设计', 28, 1, '选修');
INSERT INTO `teacherinfo` VALUES (4, 1004, '素书白', 103, '电子商务', 36, 2, '选修');
INSERT INTO `teacherinfo` VALUES (5, 1004, '素书白', 104, 'Java程序设计', 56, 3, '必修');
INSERT INTO `teacherinfo` VALUES (6, 1006, '殷千秋', 105, '软件测试', 28, 1, '选修');
INSERT INTO `teacherinfo` VALUES (7, 1007, '天春雪', 106, '操作系统', 56, 3, '必修');
INSERT INTO `teacherinfo` VALUES (8, 1006, '殷千秋', 107, '汇编语言', 36, 2, '选修');
INSERT INTO `teacherinfo` VALUES (9, 1007, '天春雪', 108, '计算机原理', 56, 3, '必修');
INSERT INTO `teacherinfo` VALUES (10, 1007, '天春雪', 109, '数据结构', 56, 3, '必修');
INSERT INTO `teacherinfo` VALUES (11, 1010, '戴泽民', 110, '计算机网络', 48, 3, '必修');
INSERT INTO `teacherinfo` VALUES (12, 1010, '戴泽民', 111, '软件需求', 35, 2, '选修');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `userid` int(11) NOT NULL AUTO_INCREMENT,
  `account` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`userid`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES (1, '1', '1');
INSERT INTO `user` VALUES (2, 'test', 'test');
INSERT INTO `user` VALUES (3, 'admin', 'admin');

SET FOREIGN_KEY_CHECKS = 1;
