// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityTeacherRequest extends TeaModel {
    // isvOrgId
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 班级ID
    @NameInMap("classId")
    public Long classId;

    // 角色
    @NameInMap("role")
    public String role;

    // 教师用户ID
    @NameInMap("teacherUserId")
    public String teacherUserId;

    // suiteKey
    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 操作人用户ID
    @NameInMap("opUserId")
    public String opUserId;

    // opOrgId
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    public static CreateUniversityTeacherRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityTeacherRequest self = new CreateUniversityTeacherRequest();
        return TeaModel.build(map, self);
    }

    public CreateUniversityTeacherRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateUniversityTeacherRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public CreateUniversityTeacherRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public CreateUniversityTeacherRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

    public CreateUniversityTeacherRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateUniversityTeacherRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateUniversityTeacherRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

}
