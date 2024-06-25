// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>&quot;city&quot;:&quot;beijing&quot;</p>
     */
    @NameInMap("empExtension")
    public java.util.Map<String, String> empExtension;

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
     * <p>2015</p>
     */
    @NameInMap("startYear")
    public String startYear;

    /**
     * <p>This parameter is required.</p>
     * 
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
