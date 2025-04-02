// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EventTrackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionKey")
    public String actionKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionTime")
    public String actionTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("bizReq")
    public String bizReq;

    @NameInMap("bizResp")
    public String bizResp;

    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("eventId")
    public String eventId;

    @NameInMap("eventType")
    public String eventType;

    @NameInMap("eventUnit")
    public String eventUnit;

    @NameInMap("eventValue")
    public String eventValue;

    @NameInMap("extend")
    public String extend;

    @NameInMap("platform")
    public String platform;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static EventTrackRequest build(java.util.Map<String, ?> map) throws Exception {
        EventTrackRequest self = new EventTrackRequest();
        return TeaModel.build(map, self);
    }

    public EventTrackRequest setActionKey(String actionKey) {
        this.actionKey = actionKey;
        return this;
    }
    public String getActionKey() {
        return this.actionKey;
    }

    public EventTrackRequest setActionTime(String actionTime) {
        this.actionTime = actionTime;
        return this;
    }
    public String getActionTime() {
        return this.actionTime;
    }

    public EventTrackRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public EventTrackRequest setBizReq(String bizReq) {
        this.bizReq = bizReq;
        return this;
    }
    public String getBizReq() {
        return this.bizReq;
    }

    public EventTrackRequest setBizResp(String bizResp) {
        this.bizResp = bizResp;
        return this;
    }
    public String getBizResp() {
        return this.bizResp;
    }

    public EventTrackRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public EventTrackRequest setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

    public EventTrackRequest setEventType(String eventType) {
        this.eventType = eventType;
        return this;
    }
    public String getEventType() {
        return this.eventType;
    }

    public EventTrackRequest setEventUnit(String eventUnit) {
        this.eventUnit = eventUnit;
        return this;
    }
    public String getEventUnit() {
        return this.eventUnit;
    }

    public EventTrackRequest setEventValue(String eventValue) {
        this.eventValue = eventValue;
        return this;
    }
    public String getEventValue() {
        return this.eventValue;
    }

    public EventTrackRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public EventTrackRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public EventTrackRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
