// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByMobileResponseBody extends TeaModel {
    @NameInMap("deptStudentInfoList")
    public java.util.List<CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList> deptStudentInfoList;

    /**
     * <strong>example:</strong>
     * <p>NORMAL</p>
     */
    @NameInMap("dingMemberStatus")
    public String dingMemberStatus;

    /**
     * <strong>example:</strong>
     * <p>”city“:&quot;Beijing&quot;</p>
     */
    @NameInMap("empExtension")
    public java.util.Map<String, ?> empExtension;

    /**
     * <strong>example:</strong>
     * <p>male</p>
     */
    @NameInMap("gender")
    public String gender;

    /**
     * <strong>example:</strong>
     * <p>11019xxxxxx0001</p>
     */
    @NameInMap("identifyId")
    public String identifyId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isActive")
    public Boolean isActive;

    /**
     * <strong>example:</strong>
     * <p>2015</p>
     */
    @NameInMap("startYear")
    public String startYear;

    /**
     * <strong>example:</strong>
     * <p>1111111</p>
     */
    @NameInMap("studentId")
    public Long studentId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("studentName")
    public String studentName;

    /**
     * <strong>example:</strong>
     * <p>11111111</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <strong>example:</strong>
     * <p>0324124</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>01123</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>student</p>
         */
        @NameInMap("memberType")
        public String memberType;

        /**
         * <strong>example:</strong>
         * <p>mf1922051</p>
         */
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
