// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsRequest extends TeaModel {
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("seriesMasterId")
    public String seriesMasterId;

    @NameInMap("showDeleted")
    public Boolean showDeleted;

    @NameInMap("syncToken")
    public String syncToken;

    @NameInMap("timeMax")
    public String timeMax;

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

    public ListEventsRequest setSeriesMasterId(String seriesMasterId) {
        this.seriesMasterId = seriesMasterId;
        return this;
    }
    public String getSeriesMasterId() {
        return this.seriesMasterId;
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
