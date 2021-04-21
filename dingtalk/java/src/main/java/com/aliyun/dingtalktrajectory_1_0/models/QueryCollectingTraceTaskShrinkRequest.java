// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskShrinkRequest extends TeaModel {
    // 员工用户ID
    @NameInMap("staffIds")
    public String staffIdsShrink;

    public static QueryCollectingTraceTaskShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectingTraceTaskShrinkRequest self = new QueryCollectingTraceTaskShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollectingTraceTaskShrinkRequest setStaffIdsShrink(String staffIdsShrink) {
        this.staffIdsShrink = staffIdsShrink;
        return this;
    }
    public String getStaffIdsShrink() {
        return this.staffIdsShrink;
    }

}
