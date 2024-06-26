// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsInstancesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cnNTbW1YbxxxxdEgvdlQrQT09</p>
     */
    @NameInMap("seriesMasterId")
    public String seriesMasterId;

    @NameInMap("startRecurrenceId")
    public String startRecurrenceId;

    public static ListEventsInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsInstancesRequest self = new ListEventsInstancesRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsInstancesRequest setMaxAttendees(Integer maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Integer getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListEventsInstancesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListEventsInstancesRequest setSeriesMasterId(String seriesMasterId) {
        this.seriesMasterId = seriesMasterId;
        return this;
    }
    public String getSeriesMasterId() {
        return this.seriesMasterId;
    }

    public ListEventsInstancesRequest setStartRecurrenceId(String startRecurrenceId) {
        this.startRecurrenceId = startRecurrenceId;
        return this;
    }
    public String getStartRecurrenceId() {
        return this.startRecurrenceId;
    }

}
