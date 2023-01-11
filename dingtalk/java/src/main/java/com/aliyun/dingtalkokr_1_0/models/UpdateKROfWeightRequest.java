// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfWeightRequest extends TeaModel {
    /**
     * <p>权重比。</p>
     */
    @NameInMap("weight")
    public Long weight;

    /**
     * <p>当前 KR ID。</p>
     */
    @NameInMap("krId")
    public String krId;

    /**
     * <p>当前用户的userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateKROfWeightRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfWeightRequest self = new UpdateKROfWeightRequest();
        return TeaModel.build(map, self);
    }

    public UpdateKROfWeightRequest setWeight(Long weight) {
        this.weight = weight;
        return this;
    }
    public Long getWeight() {
        return this.weight;
    }

    public UpdateKROfWeightRequest setKrId(String krId) {
        this.krId = krId;
        return this;
    }
    public String getKrId() {
        return this.krId;
    }

    public UpdateKROfWeightRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
