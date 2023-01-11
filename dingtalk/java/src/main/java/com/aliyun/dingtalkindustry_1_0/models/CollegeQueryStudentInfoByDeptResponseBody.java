// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByDeptResponseBody extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>学生在组织状态</p>
     */
    @NameInMap("dingMemberStatus")
    public String dingMemberStatus;

    /**
     * <p>人员拓展信息</p>
     */
    @NameInMap("empExtension")
    public java.util.Map<String, ?> empExtension;

    /**
     * <p>性别</p>
     */
    @NameInMap("gender")
    public String gender;

    /**
     * <p>身份证号</p>
     */
    @NameInMap("identifyId")
    public String identifyId;

    /**
     * <p>账号是否激活</p>
     */
    @NameInMap("isActive")
    public Boolean isActive;

    /**
     * <p>入学年月</p>
     */
    @NameInMap("startYear")
    public String startYear;

    /**
     * <p>学生id</p>
     */
    @NameInMap("studentId")
    public Long studentId;

    /**
     * <p>学生姓名</p>
     */
    @NameInMap("studentName")
    public String studentName;

    /**
     * <p>学生学号</p>
     */
    @NameInMap("studentNumber")
    public String studentNumber;

    /**
     * <p>unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CollegeQueryStudentInfoByDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByDeptResponseBody self = new CollegeQueryStudentInfoByDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByDeptResponseBody setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setDingMemberStatus(String dingMemberStatus) {
        this.dingMemberStatus = dingMemberStatus;
        return this;
    }
    public String getDingMemberStatus() {
        return this.dingMemberStatus;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setEmpExtension(java.util.Map<String, ?> empExtension) {
        this.empExtension = empExtension;
        return this;
    }
    public java.util.Map<String, ?> getEmpExtension() {
        return this.empExtension;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setGender(String gender) {
        this.gender = gender;
        return this;
    }
    public String getGender() {
        return this.gender;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setIdentifyId(String identifyId) {
        this.identifyId = identifyId;
        return this;
    }
    public String getIdentifyId() {
        return this.identifyId;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setIsActive(Boolean isActive) {
        this.isActive = isActive;
        return this;
    }
    public Boolean getIsActive() {
        return this.isActive;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setStartYear(String startYear) {
        this.startYear = startYear;
        return this;
    }
    public String getStartYear() {
        return this.startYear;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setStudentName(String studentName) {
        this.studentName = studentName;
        return this;
    }
    public String getStudentName() {
        return this.studentName;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public CollegeQueryStudentInfoByDeptResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
