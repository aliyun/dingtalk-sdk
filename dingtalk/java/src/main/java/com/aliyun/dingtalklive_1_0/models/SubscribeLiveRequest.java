// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SubscribeLiveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3dd295eb-17a1-4dfg-ae1b-aa165c5007eb</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subscribe")
    public Boolean subscribe;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6crtQT2XOgPHviiPvXhhiP6gdhiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SubscribeLiveRequest build(java.util.Map<String, ?> map) throws Exception {
        SubscribeLiveRequest self = new SubscribeLiveRequest();
        return TeaModel.build(map, self);
    }

    public SubscribeLiveRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public SubscribeLiveRequest setSubscribe(Boolean subscribe) {
        this.subscribe = subscribe;
        return this;
    }
    public Boolean getSubscribe() {
        return this.subscribe;
    }

    public SubscribeLiveRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
