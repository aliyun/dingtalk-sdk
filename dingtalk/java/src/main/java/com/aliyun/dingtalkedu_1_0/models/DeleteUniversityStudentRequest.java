// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityStudentRequest extends TeaModel {
    // 班级ID
    @NameInMap("classId")
    public Long classId;

    // 学生用户ID
    @NameInMap("studentUserId")
    public String studentUserId;

    // 操作人用户ID
    @NameInMap("opUserId")
    public String opUserId;

    public static DeleteUniversityStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityStudentRequest self = new DeleteUniversityStudentRequest();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityStudentRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public DeleteUniversityStudentRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

    public DeleteUniversityStudentRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
