// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryEventRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("deviceIdList")
    public java.util.List<String> deviceIdList;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("eventId")
    public String eventId;

    @NameInMap("eventStatusList")
    public java.util.List<Long> eventStatusList;

    @NameInMap("eventTypeList")
    public java.util.List<String> eventTypeList;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("startTime")
    public Long startTime;

    public static QueryEventRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEventRequest self = new QueryEventRequest();
        return TeaModel.build(map, self);
    }

    public QueryEventRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryEventRequest setDeviceIdList(java.util.List<String> deviceIdList) {
        this.deviceIdList = deviceIdList;
        return this;
    }
    public java.util.List<String> getDeviceIdList() {
        return this.deviceIdList;
    }

    public QueryEventRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryEventRequest setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

    public QueryEventRequest setEventStatusList(java.util.List<Long> eventStatusList) {
        this.eventStatusList = eventStatusList;
        return this;
    }
    public java.util.List<Long> getEventStatusList() {
        return this.eventStatusList;
    }

    public QueryEventRequest setEventTypeList(java.util.List<String> eventTypeList) {
        this.eventTypeList = eventTypeList;
        return this;
    }
    public java.util.List<String> getEventTypeList() {
        return this.eventTypeList;
    }

    public QueryEventRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryEventRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryEventRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
