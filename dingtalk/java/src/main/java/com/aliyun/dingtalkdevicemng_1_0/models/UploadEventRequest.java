// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UploadEventRequest extends TeaModel {
    @NameInMap("deviceUuid")
    public String deviceUuid;

    @NameInMap("content")
    public String content;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("deviceCode")
    public String deviceCode;

    @NameInMap("level")
    public String level;

    @NameInMap("eventTime")
    public String eventTime;

    @NameInMap("eventType")
    public String eventType;

    public static UploadEventRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadEventRequest self = new UploadEventRequest();
        return TeaModel.build(map, self);
    }

    public UploadEventRequest setDeviceUuid(String deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public String getDeviceUuid() {
        return this.deviceUuid;
    }

    public UploadEventRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public UploadEventRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public UploadEventRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public UploadEventRequest setLevel(String level) {
        this.level = level;
        return this;
    }
    public String getLevel() {
        return this.level;
    }

    public UploadEventRequest setEventTime(String eventTime) {
        this.eventTime = eventTime;
        return this;
    }
    public String getEventTime() {
        return this.eventTime;
    }

    public UploadEventRequest setEventType(String eventType) {
        this.eventType = eventType;
        return this;
    }
    public String getEventType() {
        return this.eventType;
    }

}
