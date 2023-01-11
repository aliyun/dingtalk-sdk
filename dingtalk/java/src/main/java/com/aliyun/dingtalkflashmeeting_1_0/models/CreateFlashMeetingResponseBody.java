// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CreateFlashMeetingResponseBody extends TeaModel {
    /**
     * <p>闪会结束时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>闪会的key</p>
     */
    @NameInMap("flashMeetingKey")
    public String flashMeetingKey;

    /**
     * <p>闪会开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>闪会标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>闪会url</p>
     */
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
