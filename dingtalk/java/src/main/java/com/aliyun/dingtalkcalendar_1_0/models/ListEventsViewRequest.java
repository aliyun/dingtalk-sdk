// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewRequest extends TeaModel {
    /**
     * <p>每个日程的参与者查询个数，默认100，最大100。</p>
     */
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    /**
     * <p>返回的最大日程数，最大100个，默认100个。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>查询翻页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询截止时间</p>
     */
    @NameInMap("timeMax")
    public String timeMax;

    /**
     * <p>查询开始时间</p>
     */
    @NameInMap("timeMin")
    public String timeMin;

    public static ListEventsViewRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsViewRequest self = new ListEventsViewRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsViewRequest setMaxAttendees(Integer maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Integer getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListEventsViewRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
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
