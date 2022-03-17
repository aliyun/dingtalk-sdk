// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsInstancesRequest extends TeaModel {
    // listInstances每个日程的参与者查询个数，默认100，最大100。
    @NameInMap("maxAttendees")
    public Long maxAttendees;

    // listInstances返回的最大日程数，最大100个，默认100个。
    @NameInMap("maxResults")
    public Long maxResults;

    // 循环主日程id。
    @NameInMap("seriesMasterId")
    public String seriesMasterId;

    // 大于此时间的所有生成实例
    @NameInMap("timeMin")
    public String timeMin;

    public static ListEventsInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEventsInstancesRequest self = new ListEventsInstancesRequest();
        return TeaModel.build(map, self);
    }

    public ListEventsInstancesRequest setMaxAttendees(Long maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Long getMaxAttendees() {
        return this.maxAttendees;
    }

    public ListEventsInstancesRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListEventsInstancesRequest setSeriesMasterId(String seriesMasterId) {
        this.seriesMasterId = seriesMasterId;
        return this;
    }
    public String getSeriesMasterId() {
        return this.seriesMasterId;
    }

    public ListEventsInstancesRequest setTimeMin(String timeMin) {
        this.timeMin = timeMin;
        return this;
    }
    public String getTimeMin() {
        return this.timeMin;
    }

}
