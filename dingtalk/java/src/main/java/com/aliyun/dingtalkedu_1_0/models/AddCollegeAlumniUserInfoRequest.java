// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniUserInfoRequest extends TeaModel {
    @NameInMap("address")
    public String address;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    @NameInMap("email")
    public String email;

    @NameInMap("intake")
    public String intake;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public String operator;

    @NameInMap("outtake")
    public String outtake;

    @NameInMap("studentNumber")
    public String studentNumber;

    public static AddCollegeAlumniUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniUserInfoRequest self = new AddCollegeAlumniUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniUserInfoRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public AddCollegeAlumniUserInfoRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public AddCollegeAlumniUserInfoRequest setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public AddCollegeAlumniUserInfoRequest setIntake(String intake) {
        this.intake = intake;
        return this;
    }
    public String getIntake() {
        return this.intake;
    }

    public AddCollegeAlumniUserInfoRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public AddCollegeAlumniUserInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddCollegeAlumniUserInfoRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public AddCollegeAlumniUserInfoRequest setOuttake(String outtake) {
        this.outtake = outtake;
        return this;
    }
    public String getOuttake() {
        return this.outtake;
    }

    public AddCollegeAlumniUserInfoRequest setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

}
