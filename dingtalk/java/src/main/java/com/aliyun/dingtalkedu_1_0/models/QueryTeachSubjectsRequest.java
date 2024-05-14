// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTeachSubjectsRequest extends TeaModel {
    @NameInMap("classIds")
    public java.util.List<Long> classIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryTeachSubjectsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTeachSubjectsRequest self = new QueryTeachSubjectsRequest();
        return TeaModel.build(map, self);
    }

    public QueryTeachSubjectsRequest setClassIds(java.util.List<Long> classIds) {
        this.classIds = classIds;
        return this;
    }
    public java.util.List<Long> getClassIds() {
        return this.classIds;
    }

    public QueryTeachSubjectsRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
