// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddStudentRequest extends TeaModel {
    // 部门编号
    @NameInMap("deptId")
    public Long deptId;

    // 人员拓展信息
    @NameInMap("empExtension")
    public java.util.Map<String, String> empExtension;

    // 性别
    @NameInMap("gender")
    public String gender;

    // 身份证号
    @NameInMap("identifyId")
    public String identifyId;

    // 手机号
    @NameInMap("mobile")
    public String mobile;

    // 入学年月
    @NameInMap("startYear")
    public String startYear;

    // 学生姓名
    @NameInMap("studentName")
    public String studentName;

    // 学生学号
    @NameInMap("studentNumber")
    public String studentNumber;

    // userId
    @NameInMap("userId")
    public String userId;

    public static CollegeAddStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddStudentRequest self = new CollegeAddStudentRequest();
        return TeaModel.build(map, self);
    }

    public CollegeAddStudentRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeAddStudentRequest setEmpExtension(java.util.Map<String, String> empExtension) {
        this.empExtension = empExtension;
        return this;
    }
    public java.util.Map<String, String> getEmpExtension() {
        return this.empExtension;
    }

    public CollegeAddStudentRequest setGender(String gender) {
        this.gender = gender;
        return this;
    }
    public String getGender() {
        return this.gender;
    }

    public CollegeAddStudentRequest setIdentifyId(String identifyId) {
        this.identifyId = identifyId;
        return this;
    }
    public String getIdentifyId() {
        return this.identifyId;
    }

    public CollegeAddStudentRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public CollegeAddStudentRequest setStartYear(String startYear) {
        this.startYear = startYear;
        return this;
    }
    public String getStartYear() {
        return this.startYear;
    }

    public CollegeAddStudentRequest setStudentName(String studentName) {
        this.studentName = studentName;
        return this;
    }
    public String getStudentName() {
        return this.studentName;
    }

    public CollegeAddStudentRequest setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

    public CollegeAddStudentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
