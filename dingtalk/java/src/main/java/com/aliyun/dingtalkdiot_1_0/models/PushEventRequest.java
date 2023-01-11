// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class PushEventRequest extends TeaModel {
    /**
     * <p>钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>触发事件设备ID。</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <p>事件ID。</p>
     */
    @NameInMap("eventId")
    public String eventId;

    /**
     * <p>事件名称，长度4-20个字符，一个中文汉字算2个字符。</p>
     */
    @NameInMap("eventName")
    public String eventName;

    /**
     * <p>事件类型，最长20个字符。</p>
     */
    @NameInMap("eventType")
    public String eventType;

    /**
     * <p>第三方平台定制参数，企业内部系统忽略。</p>
     */
    @NameInMap("extraData")
    public java.util.Map<String, ?> extraData;

    /**
     * <p>事件发生地点。</p>
     */
    @NameInMap("location")
    public String location;

    /**
     * <p>事件文字信息。</p>
     */
    @NameInMap("msg")
    public String msg;

    /**
     * <p>事件发生事件，Unix时间戳，单位毫秒。</p>
     */
    @NameInMap("occurrenceTime")
    public Long occurrenceTime;

    /**
     * <p>事件图片地址列表。</p>
     */
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
