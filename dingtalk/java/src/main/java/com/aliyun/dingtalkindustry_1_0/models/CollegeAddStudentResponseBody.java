// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddStudentResponseBody extends TeaModel {
    // 人员状态
    @NameInMap("dingMemberStatus")
    public String dingMemberStatus;

    // 账号是否激活
    @NameInMap("isActive")
    public Boolean isActive;

    // 学生id
    @NameInMap("studentId")
    public Long studentId;

    // unionId
    @NameInMap("unionId")
    public String unionId;

    // userId
    @NameInMap("userId")
    public String userId;

    public static CollegeAddStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddStudentResponseBody self = new CollegeAddStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeAddStudentResponseBody setDingMemberStatus(String dingMemberStatus) {
        this.dingMemberStatus = dingMemberStatus;
        return this;
    }
    public String getDingMemberStatus() {
        return this.dingMemberStatus;
    }

    public CollegeAddStudentResponseBody setIsActive(Boolean isActive) {
        this.isActive = isActive;
        return this;
    }
    public Boolean getIsActive() {
        return this.isActive;
    }

    public CollegeAddStudentResponseBody setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public CollegeAddStudentResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public CollegeAddStudentResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
