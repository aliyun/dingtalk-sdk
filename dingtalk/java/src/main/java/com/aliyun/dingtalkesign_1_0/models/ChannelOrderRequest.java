// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ChannelOrderRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("itemCode")
    public String itemCode;

    @NameInMap("itemName")
    public String itemName;

    @NameInMap("orderCreateTime")
    public Long orderCreateTime;

    @NameInMap("orderId")
    public String orderId;

    @NameInMap("payFee")
    public Long payFee;

    @NameInMap("quantity")
    public Long quantity;

    @NameInMap("dingIsvAccessToken")
    public String dingIsvAccessToken;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static ChannelOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ChannelOrderRequest self = new ChannelOrderRequest();
        return TeaModel.build(map, self);
    }

    public ChannelOrderRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public ChannelOrderRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public ChannelOrderRequest setItemCode(String itemCode) {
        this.itemCode = itemCode;
        return this;
    }
    public String getItemCode() {
        return this.itemCode;
    }

    public ChannelOrderRequest setItemName(String itemName) {
        this.itemName = itemName;
        return this;
    }
    public String getItemName() {
        return this.itemName;
    }

    public ChannelOrderRequest setOrderCreateTime(Long orderCreateTime) {
        this.orderCreateTime = orderCreateTime;
        return this;
    }
    public Long getOrderCreateTime() {
        return this.orderCreateTime;
    }

    public ChannelOrderRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public ChannelOrderRequest setPayFee(Long payFee) {
        this.payFee = payFee;
        return this;
    }
    public Long getPayFee() {
        return this.payFee;
    }

    public ChannelOrderRequest setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public ChannelOrderRequest setDingIsvAccessToken(String dingIsvAccessToken) {
        this.dingIsvAccessToken = dingIsvAccessToken;
        return this;
    }
    public String getDingIsvAccessToken() {
        return this.dingIsvAccessToken;
    }

    public ChannelOrderRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
