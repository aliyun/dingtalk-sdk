// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesBasicInfoResponseBody extends TeaModel {
    @NameInMap("duration")
    public Long duration;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("taskCreator")
    public String taskCreator;

    @NameInMap("taskUuid")
    public String taskUuid;

    @NameInMap("title")
    public String title;

    @NameInMap("url")
    public String url;

    public static QueryMinutesBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesBasicInfoResponseBody self = new QueryMinutesBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesBasicInfoResponseBody setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public QueryMinutesBasicInfoResponseBody setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryMinutesBasicInfoResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryMinutesBasicInfoResponseBody setTaskCreator(String taskCreator) {
        this.taskCreator = taskCreator;
        return this;
    }
    public String getTaskCreator() {
        return this.taskCreator;
    }

    public QueryMinutesBasicInfoResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public QueryMinutesBasicInfoResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public QueryMinutesBasicInfoResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
