// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityTeacherRequest extends TeaModel {
    // 班级ID
    @NameInMap("classId")
    public Long classId;

    // 操作人用户ID
    @NameInMap("opUserId")
    public String opUserId;

    // 角色
    @NameInMap("role")
    public String role;

    // 教师用户ID
    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static CreateUniversityTeacherRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityTeacherRequest self = new CreateUniversityTeacherRequest();
        return TeaModel.build(map, self);
    }

    public CreateUniversityTeacherRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public CreateUniversityTeacherRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
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

}
