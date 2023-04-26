// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityTeacherRequest extends TeaModel {
    @NameInMap("classId")
    public Long classId;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("role")
    public String role;

    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static DeleteUniversityTeacherRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityTeacherRequest self = new DeleteUniversityTeacherRequest();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityTeacherRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public DeleteUniversityTeacherRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public DeleteUniversityTeacherRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public DeleteUniversityTeacherRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

}
