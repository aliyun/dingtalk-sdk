// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskRequest extends TeaModel {
    /**
     * <p>员工用户ID列表</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static QueryCollectingTraceTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectingTraceTaskRequest self = new QueryCollectingTraceTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollectingTraceTaskRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
