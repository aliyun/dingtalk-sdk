// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PayOrderRequest extends TeaModel {
    @NameInMap("faceId")
    public String faceId;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("signature")
    public String signature;

    @NameInMap("sn")
    public String sn;

    @NameInMap("timestamp")
    public Long timestamp;

    @NameInMap("userId")
    public String userId;

    @NameInMap("version")
    public String version;

    public static PayOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        PayOrderRequest self = new PayOrderRequest();
        return TeaModel.build(map, self);
    }

    public PayOrderRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public PayOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public PayOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public PayOrderRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public PayOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public PayOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PayOrderRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
