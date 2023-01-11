// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityStudentRequest extends TeaModel {
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
     * <p>学生用户ID</p>
     */
    @NameInMap("studentUserId")
    public String studentUserId;

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

    public DeleteUniversityStudentRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public DeleteUniversityStudentRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

}
