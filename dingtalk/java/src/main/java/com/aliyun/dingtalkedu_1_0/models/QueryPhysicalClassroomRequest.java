// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPhysicalClassroomRequest extends TeaModel {
    /**
     * <p>教室id</p>
     */
    @NameInMap("classroomId")
    public Long classroomId;

    /**
     * <p>操作人id</p>
     */
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
