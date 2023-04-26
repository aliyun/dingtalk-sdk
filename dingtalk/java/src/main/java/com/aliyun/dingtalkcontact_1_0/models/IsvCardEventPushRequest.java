// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsvCardEventPushRequest extends TeaModel {
    @NameInMap("eventParams")
    public java.util.Map<String, ?> eventParams;

    @NameInMap("eventType")
    public String eventType;

    @NameInMap("isvCardId")
    public String isvCardId;

    @NameInMap("isvToken")
    public String isvToken;

    @NameInMap("isvUid")
    public String isvUid;

    public static IsvCardEventPushRequest build(java.util.Map<String, ?> map) throws Exception {
        IsvCardEventPushRequest self = new IsvCardEventPushRequest();
        return TeaModel.build(map, self);
    }

    public IsvCardEventPushRequest setEventParams(java.util.Map<String, ?> eventParams) {
        this.eventParams = eventParams;
        return this;
    }
    public java.util.Map<String, ?> getEventParams() {
        return this.eventParams;
    }

    public IsvCardEventPushRequest setEventType(String eventType) {
        this.eventType = eventType;
        return this;
    }
    public String getEventType() {
        return this.eventType;
    }

    public IsvCardEventPushRequest setIsvCardId(String isvCardId) {
        this.isvCardId = isvCardId;
        return this;
    }
    public String getIsvCardId() {
        return this.isvCardId;
    }

    public IsvCardEventPushRequest setIsvToken(String isvToken) {
        this.isvToken = isvToken;
        return this;
    }
    public String getIsvToken() {
        return this.isvToken;
    }

    public IsvCardEventPushRequest setIsvUid(String isvUid) {
        this.isvUid = isvUid;
        return this;
    }
    public String getIsvUid() {
        return this.isvUid;
    }

}
