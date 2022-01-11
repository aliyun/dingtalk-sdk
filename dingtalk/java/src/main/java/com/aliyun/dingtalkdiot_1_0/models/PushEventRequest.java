// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class PushEventRequest extends TeaModel {
    // 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
    @NameInMap("corpId")
    public String corpId;

    // 触发事件设备ID。
    @NameInMap("deviceId")
    public String deviceId;

    // 事件ID。
    @NameInMap("eventId")
    public String eventId;

    // 事件名称，长度4-20个字符，一个中文汉字算2个字符。
    @NameInMap("eventName")
    public String eventName;

    // 事件类型，最长20个字符。
    @NameInMap("eventType")
    public String eventType;

    // 第三方平台定制参数，企业内部系统忽略。
    @NameInMap("extraData")
    public java.util.Map<String, ?> extraData;

    // 事件发生地点。
    @NameInMap("location")
    public String location;

    // 事件文字信息。
    @NameInMap("msg")
    public String msg;

    // 事件发生事件，Unix时间戳，单位毫秒。
    @NameInMap("occurrenceTime")
    public Long occurrenceTime;

    // 事件图片地址列表。
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
