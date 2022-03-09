// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfWeightRequest extends TeaModel {
    @NameInMap("weight")
    public Long weight;

    // A short description of struct
    @NameInMap("krId")
    public java.io.InputStream krId;

    @NameInMap("ownerId")
    public java.io.InputStream ownerId;

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

    public UpdateKROfWeightRequest setKrId(java.io.InputStream krId) {
        this.krId = krId;
        return this;
    }
    public java.io.InputStream getKrId() {
        return this.krId;
    }

    public UpdateKROfWeightRequest setOwnerId(java.io.InputStream ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public java.io.InputStream getOwnerId() {
        return this.ownerId;
    }

}
