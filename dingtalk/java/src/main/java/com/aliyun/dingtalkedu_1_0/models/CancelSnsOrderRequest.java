// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelSnsOrderRequest extends TeaModel {
    // 支付宝应用id。
    @NameInMap("alipayAppId")
    public String alipayAppId;

    // 商户id。
    @NameInMap("merchantId")
    public String merchantId;

    // 订单号。
    @NameInMap("orderNo")
    public String orderNo;

    // 签名。
    @NameInMap("signature")
    public String signature;

    // 时间戳。
    @NameInMap("timestamp")
    public Long timestamp;

    public static CancelSnsOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelSnsOrderRequest self = new CancelSnsOrderRequest();
        return TeaModel.build(map, self);
    }

    public CancelSnsOrderRequest setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CancelSnsOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CancelSnsOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CancelSnsOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CancelSnsOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
