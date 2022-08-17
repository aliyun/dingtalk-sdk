// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelUserOrderRequest extends TeaModel {
    // 应用id。
    @NameInMap("appId")
    public String appId;

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

    public static CancelUserOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelUserOrderRequest self = new CancelUserOrderRequest();
        return TeaModel.build(map, self);
    }

    public CancelUserOrderRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
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
