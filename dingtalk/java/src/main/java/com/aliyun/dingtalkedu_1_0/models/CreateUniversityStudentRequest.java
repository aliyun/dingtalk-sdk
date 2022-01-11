// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityStudentRequest extends TeaModel {
    // 班级id
    @NameInMap("classId")
    public Long classId;

    // 性别
    @NameInMap("gender")
    public String gender;

    // 身份证号
    @NameInMap("identityNumber")
    public String identityNumber;

    // 电话
    @NameInMap("mobile")
    public String mobile;

    // 名字
    @NameInMap("name")
    public String name;

    // 学号
    @NameInMap("studentNumber")
    public String studentNumber;

    // opUserId
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
