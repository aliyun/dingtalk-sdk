// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityStudentRequest extends TeaModel {
    @NameInMap("classId")
    public Long classId;

    @NameInMap("gender")
    public String gender;

    @NameInMap("identityNumber")
    public String identityNumber;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("name")
    public String name;

    @NameInMap("studentNumber")
    public String studentNumber;

    @NameInMap("opUserId")
    public String opUserId;

    public static CreateUniversityStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityStudentRequest self = new CreateUniversityStudentRequest();
        return TeaModel.build(map, self);
    }

    public CreateUniversityStudentRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public CreateUniversityStudentRequest setGender(String gender) {
        this.gender = gender;
        return this;
    }
    public String getGender() {
        return this.gender;
    }

    public CreateUniversityStudentRequest setIdentityNumber(String identityNumber) {
        this.identityNumber = identityNumber;
        return this;
    }
    public String getIdentityNumber() {
        return this.identityNumber;
    }

    public CreateUniversityStudentRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public CreateUniversityStudentRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateUniversityStudentRequest setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

    public CreateUniversityStudentRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
