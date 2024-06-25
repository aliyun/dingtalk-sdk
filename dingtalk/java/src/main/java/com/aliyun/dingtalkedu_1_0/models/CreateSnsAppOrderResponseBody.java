// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSnsAppOrderResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <strong>example:</strong>
     * <p>alipay_sdk=alipay-sdk-java-dynamicVersionNo&amp;version=1.0</p>
     */
    @NameInMap("body")
    public String body;

    /**
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <strong>example:</strong>
     * <p>M00001</p>
     */
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    /**
     * <strong>example:</strong>
     * <p>CM0001</p>
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
