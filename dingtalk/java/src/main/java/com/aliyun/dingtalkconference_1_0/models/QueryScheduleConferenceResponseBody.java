// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConferenceResponseBody extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("phones")
    public java.util.List<String> phones;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("roomCode")
    public String roomCode;

    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

    @NameInMap("url")
    public String url;

    public static QueryScheduleConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConferenceResponseBody self = new QueryScheduleConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConferenceResponseBody setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryScheduleConferenceResponseBody setPhones(java.util.List<String> phones) {
        this.phones = phones;
        return this;
    }
    public java.util.List<String> getPhones() {
        return this.phones;
    }

    public QueryScheduleConferenceResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryScheduleConferenceResponseBody setRoomCode(String roomCode) {
        this.roomCode = roomCode;
        return this;
    }
    public String getRoomCode() {
        return this.roomCode;
    }

    public QueryScheduleConferenceResponseBody setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

    public QueryScheduleConferenceResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryScheduleConferenceResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public QueryScheduleConferenceResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
