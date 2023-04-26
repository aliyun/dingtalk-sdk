// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByStudentIdResponseBody extends TeaModel {
    @NameInMap("deptStudentInfoList")
    public java.util.List<CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList> deptStudentInfoList;

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

    public static CollegeQueryStudentInfoByStudentIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByStudentIdResponseBody self = new CollegeQueryStudentInfoByStudentIdResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setDeptStudentInfoList(java.util.List<CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList> deptStudentInfoList) {
        this.deptStudentInfoList = deptStudentInfoList;
        return this;
    }
    public java.util.List<CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList> getDeptStudentInfoList() {
        return this.deptStudentInfoList;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setDingMemberStatus(String dingMemberStatus) {
        this.dingMemberStatus = dingMemberStatus;
        return this;
    }
    public String getDingMemberStatus() {
        return this.dingMemberStatus;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setEmpExtension(java.util.Map<String, ?> empExtension) {
        this.empExtension = empExtension;
        return this;
    }
    public java.util.Map<String, ?> getEmpExtension() {
        return this.empExtension;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setGender(String gender) {
        this.gender = gender;
        return this;
    }
    public String getGender() {
        return this.gender;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setIdentifyId(String identifyId) {
        this.identifyId = identifyId;
        return this;
    }
    public String getIdentifyId() {
        return this.identifyId;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setIsActive(Boolean isActive) {
        this.isActive = isActive;
        return this;
    }
    public Boolean getIsActive() {
        return this.isActive;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setStartYear(String startYear) {
        this.startYear = startYear;
        return this;
    }
    public String getStartYear() {
        return this.startYear;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setStudentName(String studentName) {
        this.studentName = studentName;
        return this;
    }
    public String getStudentName() {
        return this.studentName;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public CollegeQueryStudentInfoByStudentIdResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("memberType")
        public String memberType;

        @NameInMap("studentNumber")
        public String studentNumber;

        public static CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList build(java.util.Map<String, ?> map) throws Exception {
            CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList self = new CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList();
            return TeaModel.build(map, self);
        }

        public CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList setStudentNumber(String studentNumber) {
            this.studentNumber = studentNumber;
            return this;
        }
        public String getStudentNumber() {
            return this.studentNumber;
        }

    }

}
