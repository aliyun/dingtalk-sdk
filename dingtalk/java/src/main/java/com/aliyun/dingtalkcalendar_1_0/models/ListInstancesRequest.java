// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListInstancesRequest extends TeaModel {
    // 每个日程的参与者查询个数，默认100，最大100
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    // 返回的最大日程数，最大100个，默认100个
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 查询截止时间
    @NameInMap("timeMax")
    public String timeMax;

    // 查询开始时间
    @NameInMap("timeMin")
    public String timeMin;

    public static ListInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListInstancesRequest self = new ListInstancesRequest();
        return TeaModel.build(map, self);
    }

    public ListInstancesRequest setMaxAttendees(Integer maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Integer getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListInstancesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListInstancesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListInstancesRequest setTimeMax(String timeMax) {
        this.timeMax = timeMax;
        return this;
    }
    public String getTimeMax() {
        return this.timeMax;
    }

    public ListInstancesRequest setTimeMin(String timeMin) {
        this.timeMin = timeMin;
        return this;
    }
    public String getTimeMin() {
        return this.timeMin;
    }

}
