// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByMobileResponseBody extends TeaModel {
    @NameInMap("deptStudentInfoList")
    public java.util.List<CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList> deptStudentInfoList;

    @NameInMap("dingMemberStatus")
    public String dingMemberStatus;

    @NameInMap("empExtension")
    public java.util.Map<String, ?> empExtension;

    @NameInMap("gender")
    public String gender;

    @NameInMap("identifyId")
    public String identifyId;

    @NameInMap("isActive")
    public Boolean isActive;

    @NameInMap("startYear")
    public String startYear;

    @NameInMap("studentId")
    public Long studentId;

    @NameInMap("studentName")
    public String studentName;

    @NameInMap("unionId")
    public String unionId;

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
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("memberType")
        public String memberType;

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
