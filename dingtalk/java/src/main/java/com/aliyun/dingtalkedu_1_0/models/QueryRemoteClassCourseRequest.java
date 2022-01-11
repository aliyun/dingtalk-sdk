// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryRemoteClassCourseRequest extends TeaModel {
    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 操作者用户ID
    @NameInMap("operator")
    public String operator;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    public static QueryRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRemoteClassCourseRequest self = new QueryRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public QueryRemoteClassCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryRemoteClassCourseRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public QueryRemoteClassCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
