// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewByMeRequest extends TeaModel {
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("timeMax")
    public String timeMax;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("timeMin")
    public String timeMin;

    public static ListEventsViewByMeRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsViewByMeRequest self = new ListEventsViewByMeRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsViewByMeRequest setMaxAttendees(Integer maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Integer getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListEventsViewByMeRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListEventsViewByMeRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEventsViewByMeRequest setTimeMax(String timeMax) {
        this.timeMax = timeMax;
        return this;
    }
    public String getTimeMax() {
        return this.timeMax;
    }

    public ListEventsViewByMeRequest setTimeMin(String timeMin) {
        this.timeMin = timeMin;
        return this;
    }
    public String getTimeMin() {
        return this.timeMin;
    }

}
