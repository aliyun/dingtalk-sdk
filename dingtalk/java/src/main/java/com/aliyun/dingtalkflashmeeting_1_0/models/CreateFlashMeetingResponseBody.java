// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CreateFlashMeetingResponseBody extends TeaModel {
    // 闪会结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 闪会的key
    @NameInMap("flashMeetingKey")
    public String flashMeetingKey;

    // 闪会开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 闪会标题
    @NameInMap("title")
    public String title;

    // 闪会url
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
