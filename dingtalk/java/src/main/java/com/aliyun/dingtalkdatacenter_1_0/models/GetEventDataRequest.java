// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEventDataRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>819e50d7c32e9096</p>
     */
    @NameInMap("eventUid")
    public String eventUid;

    @NameInMap("subId")
    public String subId;

    public static GetEventDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEventDataRequest self = new GetEventDataRequest();
        return TeaModel.build(map, self);
    }

    public GetEventDataRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public GetEventDataRequest setEventUid(String eventUid) {
        this.eventUid = eventUid;
        return this;
    }
    public String getEventUid() {
        return this.eventUid;
    }

    public GetEventDataRequest setSubId(String subId) {
        this.subId = subId;
        return this;
    }
    public String getSubId() {
        return this.subId;
    }

}
