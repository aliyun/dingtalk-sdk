// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeletePhysicalClassroomRequest extends TeaModel {
    // 教室主键
    @NameInMap("classroomId")
    public Long classroomId;

    // 操作人id
    @NameInMap("opUserId")
    public String opUserId;

    public static DeletePhysicalClassroomRequest build(java.util.Map<String, ?> map) throws Exception {
        DeletePhysicalClassroomRequest self = new DeletePhysicalClassroomRequest();
        return TeaModel.build(map, self);
    }

    public DeletePhysicalClassroomRequest setClassroomId(Long classroomId) {
        this.classroomId = classroomId;
        return this;
    }
    public Long getClassroomId() {
        return this.classroomId;
    }

    public DeletePhysicalClassroomRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
