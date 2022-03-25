// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsRequest extends TeaModel {
    // 每个日程的参与者查询个数，默认100，最大100
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    // 返回的最大日程数，最大100个，默认100个
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 是否返回删除事件
    @NameInMap("showDeleted")
    public Boolean showDeleted;

    // 增量查询token
    @NameInMap("syncToken")
    public String syncToken;

    // 查询截止时间
    @NameInMap("timeMax")
    public String timeMax;

    // 查询开始时间
    @NameInMap("timeMin")
    public String timeMin;

    public static ListEventsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsRequest self = new ListEventsRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsRequest setMaxAttendees(Integer maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Integer getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListEventsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListEventsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEventsRequest setShowDeleted(Boolean showDeleted) {
        this.showDeleted = showDeleted;
        return this;
    }
    public Boolean getShowDeleted() {
        return this.showDeleted;
    }

    public ListEventsRequest setSyncToken(String syncToken) {
        this.syncToken = syncToken;
        return this;
    }
    public String getSyncToken() {
        return this.syncToken;
    }

    public ListEventsRequest setTimeMax(String timeMax) {
        this.timeMax = timeMax;
        return this;
    }
    public String getTimeMax() {
        return this.timeMax;
    }

    public ListEventsRequest setTimeMin(String timeMin) {
        this.timeMin = timeMin;
        return this;
    }
    public String getTimeMin() {
        return this.timeMin;
    }

}
