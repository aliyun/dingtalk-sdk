// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityStudentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("classId")
    public Long classId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
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
