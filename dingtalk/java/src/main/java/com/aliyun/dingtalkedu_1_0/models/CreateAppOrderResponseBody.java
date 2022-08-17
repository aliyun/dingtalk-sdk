// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAppOrderResponseBody extends TeaModel {
    // 实际金额，单位分。
    @NameInMap("actualAmount")
    public Long actualAmount;

    // 应用id。
    @NameInMap("appId")
    public String appId;

    // 订单信息。
    @NameInMap("body")
    public String body;

    // 商户id。
    @NameInMap("merchantId")
    public String merchantId;

    // 商户订单号。
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    // 订单号。
    @NameInMap("orderNo")
    public String orderNo;

    public static CreateAppOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAppOrderResponseBody self = new CreateAppOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAppOrderResponseBody setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateAppOrderResponseBody setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public CreateAppOrderResponseBody setBody(String body) {
        this.body = body;
        return this;
    }
    public String getBody() {
        return this.body;
    }

    public CreateAppOrderResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateAppOrderResponseBody setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public CreateAppOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

}
