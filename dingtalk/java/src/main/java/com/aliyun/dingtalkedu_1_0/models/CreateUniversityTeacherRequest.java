// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityTeacherRequest extends TeaModel {
    /**
     * <p>班级ID</p>
     */
    @NameInMap("classId")
    public Long classId;

    /**
     * <p>操作人用户ID</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>角色</p>
     */
    @NameInMap("role")
    public String role;

    /**
     * <p>教师用户ID</p>
     */
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
