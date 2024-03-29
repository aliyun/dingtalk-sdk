// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelUserOrderRequest extends TeaModel {
    @NameInMap("alipayAppId")
    public String alipayAppId;

    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("signature")
    public String signature;

    @NameInMap("timestamp")
    public Long timestamp;

    public static CancelUserOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelUserOrderRequest self = new CancelUserOrderRequest();
        return TeaModel.build(map, self);
    }

    public CancelUserOrderRequest setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CancelUserOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CancelUserOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CancelUserOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CancelUserOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
