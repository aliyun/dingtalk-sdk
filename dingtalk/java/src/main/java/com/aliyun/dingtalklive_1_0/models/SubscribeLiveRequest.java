// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SubscribeLiveRequest extends TeaModel {
    /**
     * <p>直播uuid</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>true:关注 false:取消关注</p>
     */
    @NameInMap("subscribe")
    public Boolean subscribe;

    /**
     * <p>用户id</p>
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
