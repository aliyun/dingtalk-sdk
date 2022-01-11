// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPhysicalClassroomRequest extends TeaModel {
    // 教室id
    @NameInMap("classroomId")
    public Long classroomId;

    // 操作人id
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryPhysicalClassroomRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPhysicalClassroomRequest self = new QueryPhysicalClassroomRequest();
        return TeaModel.build(map, self);
    }

    public QueryPhysicalClassroomRequest setClassroomId(Long classroomId) {
        this.classroomId = classroomId;
        return this;
    }
    public Long getClassroomId() {
        return this.classroomId;
    }

    public QueryPhysicalClassroomRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
