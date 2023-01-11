// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrderRequest extends TeaModel {
    /**
     * <p>支付宝应用id。</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <p>商户id。</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>订单号。</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>签名。</p>
     */
    @NameInMap("signature")
    public String signature;

    public static QueryOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrderRequest self = new QueryOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrderRequest setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public QueryOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QueryOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

}
