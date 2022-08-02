// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentInfoRequest extends TeaModel {
    // 人员拓展信息
    @NameInMap("empExtension")
    public java.util.Map<String, String> empExtension;

    // 性别
    @NameInMap("gender")
    public String gender;

    // 身份证号
    @NameInMap("identifyId")
    public String identifyId;

    // 入学年份
    @NameInMap("startYear")
    public String startYear;

    // studentId
    @NameInMap("studentId")
    public Long studentId;

    // 学生姓名
    @NameInMap("studentName")
    public String studentName;

    public static CollegeUpdateStudentInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentInfoRequest self = new CollegeUpdateStudentInfoRequest();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentInfoRequest setEmpExtension(java.util.Map<String, String> empExtension) {
        this.empExtension = empExtension;
        return this;
    }
    public java.util.Map<String, String> getEmpExtension() {
        return this.empExtension;
    }

    public CollegeUpdateStudentInfoRequest setGender(String gender) {
        this.gender = gender;
        return this;
    }
    public String getGender() {
        return this.gender;
    }

    public CollegeUpdateStudentInfoRequest setIdentifyId(String identifyId) {
        this.identifyId = identifyId;
        return this;
    }
    public String getIdentifyId() {
        return this.identifyId;
    }

    public CollegeUpdateStudentInfoRequest setStartYear(String startYear) {
        this.startYear = startYear;
        return this;
    }
    public String getStartYear() {
        return this.startYear;
    }

    public CollegeUpdateStudentInfoRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public CollegeUpdateStudentInfoRequest setStudentName(String studentName) {
        this.studentName = studentName;
        return this;
    }
    public String getStudentName() {
        return this.studentName;
    }

}
