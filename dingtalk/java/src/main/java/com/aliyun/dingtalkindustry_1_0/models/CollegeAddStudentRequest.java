// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddStudentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6235234</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <strong>example:</strong>
     * <p>”city“:&quot;Beijing&quot;</p>
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>186xxxxxxxx</p>
     */
    @NameInMap("mobile")
    public String mobile;

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
     * <p>张三</p>
     */
    @NameInMap("studentName")
    public String studentName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>mf1922051</p>
     */
    @NameInMap("studentNumber")
    public String studentNumber;

    /**
     * <strong>example:</strong>
     * <p>0324124</p>
     */
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
