// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsInstancesRequest extends TeaModel {
    // listInstances每个日程的参与者查询个数，默认100，最大100。
    @NameInMap("maxAttendees")
    public Integer maxAttendees;

    // listInstances返回的最大日程数，最大100个，默认100个。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 循环主日程id。
    @NameInMap("seriesMasterId")
    public String seriesMasterId;

    // 大于等于次序列id的所有实例
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
