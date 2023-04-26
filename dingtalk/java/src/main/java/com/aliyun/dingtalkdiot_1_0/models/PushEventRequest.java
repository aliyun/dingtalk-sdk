// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class PushEventRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("deviceId")
    public String deviceId;

    @NameInMap("eventId")
    public String eventId;

    @NameInMap("eventName")
    public String eventName;

    @NameInMap("eventType")
    public String eventType;

    @NameInMap("extraData")
    public java.util.Map<String, ?> extraData;

    @NameInMap("location")
    public String location;

    @NameInMap("msg")
    public String msg;

    @NameInMap("occurrenceTime")
    public Long occurrenceTime;

    @NameInMap("picUrls")
    public java.util.List<String> picUrls;

    public static PushEventRequest build(java.util.Map<String, ?> map) throws Exception {
        PushEventRequest self = new PushEventRequest();
        return TeaModel.build(map, self);
    }

    public PushEventRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public PushEventRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public PushEventRequest setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

    public PushEventRequest setEventName(String eventName) {
        this.eventName = eventName;
        return this;
    }
    public String getEventName() {
        return this.eventName;
    }

    public PushEventRequest setEventType(String eventType) {
        this.eventType = eventType;
        return this;
    }
    public String getEventType() {
        return this.eventType;
    }

    public PushEventRequest setExtraData(java.util.Map<String, ?> extraData) {
        this.extraData = extraData;
        return this;
    }
    public java.util.Map<String, ?> getExtraData() {
        return this.extraData;
    }

    public PushEventRequest setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public PushEventRequest setMsg(String msg) {
        this.msg = msg;
        return this;
    }
    public String getMsg() {
        return this.msg;
    }

    public PushEventRequest setOccurrenceTime(Long occurrenceTime) {
        this.occurrenceTime = occurrenceTime;
        return this;
    }
    public Long getOccurrenceTime() {
        return this.occurrenceTime;
    }

    public PushEventRequest setPicUrls(java.util.List<String> picUrls) {
        this.picUrls = picUrls;
        return this;
    }
    public java.util.List<String> getPicUrls() {
        return this.picUrls;
    }

}
