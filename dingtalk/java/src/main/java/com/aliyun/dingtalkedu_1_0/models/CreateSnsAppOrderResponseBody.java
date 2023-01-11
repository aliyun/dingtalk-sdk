// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSnsAppOrderResponseBody extends TeaModel {
    /**
     * <p>实际金额，单位分。</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <p>支付宝应用id。</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <p>订单信息。</p>
     */
    @NameInMap("body")
    public String body;

    /**
     * <p>商户id。</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>商户订单号。</p>
     */
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    /**
     * <p>订单号。</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    public static CreateSnsAppOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSnsAppOrderResponseBody self = new CreateSnsAppOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSnsAppOrderResponseBody setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateSnsAppOrderResponseBody setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CreateSnsAppOrderResponseBody setBody(String body) {
        this.body = body;
        return this;
    }
    public String getBody() {
        return this.body;
    }

    public CreateSnsAppOrderResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateSnsAppOrderResponseBody setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public CreateSnsAppOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

}
