// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeAlumniUserInfoRequest extends TeaModel {
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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateCollegeAlumniUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeAlumniUserInfoRequest self = new UpdateCollegeAlumniUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeAlumniUserInfoRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public UpdateCollegeAlumniUserInfoRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public UpdateCollegeAlumniUserInfoRequest setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public UpdateCollegeAlumniUserInfoRequest setIntake(String intake) {
        this.intake = intake;
        return this;
    }
    public String getIntake() {
        return this.intake;
    }

    public UpdateCollegeAlumniUserInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateCollegeAlumniUserInfoRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateCollegeAlumniUserInfoRequest setOuttake(String outtake) {
        this.outtake = outtake;
        return this;
    }
    public String getOuttake() {
        return this.outtake;
    }

    public UpdateCollegeAlumniUserInfoRequest setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

    public UpdateCollegeAlumniUserInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
