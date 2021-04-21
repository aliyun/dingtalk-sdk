// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskRequest extends TeaModel {
    // 员工用户ID
    @NameInMap("staffIds")
    public java.util.List<String> staffIds;

    public static QueryCollectingTraceTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectingTraceTaskRequest self = new QueryCollectingTraceTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollectingTraceTaskRequest setStaffIds(java.util.List<String> staffIds) {
        this.staffIds = staffIds;
        return this;
    }
    public java.util.List<String> getStaffIds() {
        return this.staffIds;
    }

}
