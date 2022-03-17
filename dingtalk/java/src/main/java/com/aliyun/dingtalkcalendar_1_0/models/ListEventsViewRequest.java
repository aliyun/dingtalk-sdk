// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewRequest extends TeaModel {
    // 每个日程的参与者查询个数，默认100，最大100。
    @NameInMap("maxAttendees")
    public Long maxAttendees;

    // 返回的最大日程数，最大100个，默认100个。
    @NameInMap("maxResults")
    public Long maxResults;

    // 查询翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 查询截止时间
    @NameInMap("timeMax")
    public String timeMax;

    // 查询开始时间
    @NameInMap("timeMin")
    public String timeMin;

    public static ListEventsViewRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsViewRequest self = new ListEventsViewRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsViewRequest setMaxAttendees(Long maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Long getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListEventsViewRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListEventsViewRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEventsViewRequest setTimeMax(String timeMax) {
        this.timeMax = timeMax;
        return this;
    }
    public String getTimeMax() {
        return this.timeMax;
    }

    public ListEventsViewRequest setTimeMin(String timeMin) {
        this.timeMin = timeMin;
        return this;
    }
    public String getTimeMin() {
        return this.timeMin;
    }

}
