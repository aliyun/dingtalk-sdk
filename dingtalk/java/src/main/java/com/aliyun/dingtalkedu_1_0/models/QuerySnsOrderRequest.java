// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySnsOrderRequest extends TeaModel {
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

    public static QuerySnsOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySnsOrderRequest self = new QuerySnsOrderRequest();
        return TeaModel.build(map, self);
    }

    public QuerySnsOrderRequest setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public QuerySnsOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QuerySnsOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QuerySnsOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

}
