// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsvCardEventPushRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("eventParams")
    public java.util.Map<String, ?> eventParams;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("eventType")
    public String eventType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isvCardId")
    public String isvCardId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isvToken")
    public String isvToken;

    /**
     * <p>This parameter is required.</p>
     */
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
