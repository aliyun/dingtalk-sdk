// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyFreshOrderRequest extends TeaModel {
    // 阿里云产品码
    @NameInMap("produceCode")
    public String produceCode;

    // 实例id
    @NameInMap("instanceId")
    public String instanceId;

    // 实例名称
    @NameInMap("instanceName")
    public String instanceName;

    // 访问秘钥
    @NameInMap("accessKey")
    public String accessKey;

    // 调用者unionId
    @NameInMap("callerUnionId")
    public String callerUnionId;

    // 收费类型
    @NameInMap("chargeType")
    public String chargeType;

    // 结束时间
    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    // 开始时间
    @NameInMap("beginTimeGMT")
    public Long beginTimeGMT;

    // 账户号
    @NameInMap("accountNumber")
    public String accountNumber;

    // 商业类型
    @NameInMap("commerceType")
    public String commerceType;

    // 商品类型
    @NameInMap("commodityType")
    public String commodityType;

    public static BuyFreshOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        BuyFreshOrderRequest self = new BuyFreshOrderRequest();
        return TeaModel.build(map, self);
    }

    public BuyFreshOrderRequest setProduceCode(String produceCode) {
        this.produceCode = produceCode;
        return this;
    }
    public String getProduceCode() {
        return this.produceCode;
    }

    public BuyFreshOrderRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public BuyFreshOrderRequest setInstanceName(String instanceName) {
        this.instanceName = instanceName;
        return this;
    }
    public String getInstanceName() {
        return this.instanceName;
    }

    public BuyFreshOrderRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public BuyFreshOrderRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public BuyFreshOrderRequest setChargeType(String chargeType) {
        this.chargeType = chargeType;
        return this;
    }
    public String getChargeType() {
        return this.chargeType;
    }

    public BuyFreshOrderRequest setEndTimeGMT(Long endTimeGMT) {
        this.endTimeGMT = endTimeGMT;
        return this;
    }
    public Long getEndTimeGMT() {
        return this.endTimeGMT;
    }

    public BuyFreshOrderRequest setBeginTimeGMT(Long beginTimeGMT) {
        this.beginTimeGMT = beginTimeGMT;
        return this;
    }
    public Long getBeginTimeGMT() {
        return this.beginTimeGMT;
    }

    public BuyFreshOrderRequest setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }
    public String getAccountNumber() {
        return this.accountNumber;
    }

    public BuyFreshOrderRequest setCommerceType(String commerceType) {
        this.commerceType = commerceType;
        return this;
    }
    public String getCommerceType() {
        return this.commerceType;
    }

    public BuyFreshOrderRequest setCommodityType(String commodityType) {
        this.commodityType = commodityType;
        return this;
    }
    public String getCommodityType() {
        return this.commodityType;
    }

}
