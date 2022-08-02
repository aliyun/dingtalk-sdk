// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByMobileResponseBody extends TeaModel {
    // 部门拓展信息列表
    @NameInMap("deptStudentInfoList")
    public java.util.List<CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList> deptStudentInfoList;

    // 学生在组织状态
    @NameInMap("dingMemberStatus")
    public String dingMemberStatus;

    // 人员拓展信息
    @NameInMap("empExtension")
    public java.util.Map<String, ?> empExtension;

    // 性别
    @NameInMap("gender")
    public String gender;

    // 身份证号
    @NameInMap("identifyId")
    public String identifyId;

    // 账号是否激活
    @NameInMap("isActive")
    public Boolean isActive;

    // 入学年月
    @NameInMap("startYear")
    public String startYear;

    // 学生id
    @NameInMap("studentId")
    public Long studentId;

    // 学生姓名
    @NameInMap("studentName")
    public String studentName;

    // unionId
    @NameInMap("unionId")
    public String unionId;

    // userId
    @NameInMap("userId")
    public String userId;

    public static CollegeQueryStudentInfoByMobileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByMobileResponseBody self = new CollegeQueryStudentInfoByMobileResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByMobileResponseBody setDeptStudentInfoList(java.util.List<CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList> deptStudentInfoList) {
        this.deptStudentInfoList = deptStudentInfoList;
        return this;
    }
    public java.util.List<CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList> getDeptStudentInfoList() {
        return this.deptStudentInfoList;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setDingMemberStatus(String dingMemberStatus) {
        this.dingMemberStatus = dingMemberStatus;
        return this;
    }
    public String getDingMemberStatus() {
        return this.dingMemberStatus;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setEmpExtension(java.util.Map<String, ?> empExtension) {
        this.empExtension = empExtension;
        return this;
    }
    public java.util.Map<String, ?> getEmpExtension() {
        return this.empExtension;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setGender(String gender) {
        this.gender = gender;
        return this;
    }
    public String getGender() {
        return this.gender;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setIdentifyId(String identifyId) {
        this.identifyId = identifyId;
        return this;
    }
    public String getIdentifyId() {
        return this.identifyId;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setIsActive(Boolean isActive) {
        this.isActive = isActive;
        return this;
    }
    public Boolean getIsActive() {
        return this.isActive;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setStartYear(String startYear) {
        this.startYear = startYear;
        return this;
    }
    public String getStartYear() {
        return this.startYear;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setStudentName(String studentName) {
        this.studentName = studentName;
        return this;
    }
    public String getStudentName() {
        return this.studentName;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public CollegeQueryStudentInfoByMobileResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList extends TeaModel {
        // 部门id
        @NameInMap("deptId")
        public Long deptId;

        // 人员类别
        @NameInMap("memberType")
        public String memberType;

        // 学生学号
        @NameInMap("studentNumber")
        public String studentNumber;

        public static CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList build(java.util.Map<String, ?> map) throws Exception {
            CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList self = new CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList();
            return TeaModel.build(map, self);
        }

        public CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList setStudentNumber(String studentNumber) {
            this.studentNumber = studentNumber;
            return this;
        }
        public String getStudentNumber() {
            return this.studentNumber;
        }

    }

}
