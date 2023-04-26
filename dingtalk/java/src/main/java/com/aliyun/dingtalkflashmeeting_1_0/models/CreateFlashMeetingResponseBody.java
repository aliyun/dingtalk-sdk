// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CreateFlashMeetingResponseBody extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("flashMeetingKey")
    public String flashMeetingKey;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

    @NameInMap("url")
    public String url;

    public static CreateFlashMeetingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFlashMeetingResponseBody self = new CreateFlashMeetingResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFlashMeetingResponseBody setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateFlashMeetingResponseBody setFlashMeetingKey(String flashMeetingKey) {
        this.flashMeetingKey = flashMeetingKey;
        return this;
    }
    public String getFlashMeetingKey() {
        return this.flashMeetingKey;
    }

    public CreateFlashMeetingResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateFlashMeetingResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateFlashMeetingResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
