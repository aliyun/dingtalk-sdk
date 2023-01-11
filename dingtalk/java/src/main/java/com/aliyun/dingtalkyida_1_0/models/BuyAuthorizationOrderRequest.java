// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyAuthorizationOrderRequest extends TeaModel {
    /**
     * <p>访问秘钥</p>
     */
    @NameInMap("accessKey")
    public String accessKey;

    /**
     * <p>账户号</p>
     */
    @NameInMap("accountNumber")
    public String accountNumber;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("beginTimeGMT")
    public Long beginTimeGMT;

    /**
     * <p>调用者unionId</p>
     */
    @NameInMap("callerUnionId")
    public String callerUnionId;

    /**
     * <p>收费类型</p>
     */
    @NameInMap("chargeType")
    public String chargeType;

    /**
     * <p>商业类型</p>
     */
    @NameInMap("commerceType")
    public String commerceType;

    /**
     * <p>商品类型</p>
     */
    @NameInMap("commodityType")
    public String commodityType;

    /**
     * <p>结束时间</p>
     */
    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    /**
     * <p>实例id</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <p>实例名称</p>
     */
    @NameInMap("instanceName")
    public String instanceName;

    /**
     * <p>阿里云产品码</p>
     */
    @NameInMap("produceCode")
    public String produceCode;

    public static BuyAuthorizationOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        BuyAuthorizationOrderRequest self = new BuyAuthorizationOrderRequest();
        return TeaModel.build(map, self);
    }

    public BuyAuthorizationOrderRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public BuyAuthorizationOrderRequest setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }
    public String getAccountNumber() {
        return this.accountNumber;
    }

    public BuyAuthorizationOrderRequest setBeginTimeGMT(Long beginTimeGMT) {
        this.beginTimeGMT = beginTimeGMT;
        return this;
    }
    public Long getBeginTimeGMT() {
        return this.beginTimeGMT;
    }

    public BuyAuthorizationOrderRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public BuyAuthorizationOrderRequest setChargeType(String chargeType) {
        this.chargeType = chargeType;
        return this;
    }
    public String getChargeType() {
        return this.chargeType;
    }

    public BuyAuthorizationOrderRequest setCommerceType(String commerceType) {
        this.commerceType = commerceType;
        return this;
    }
    public String getCommerceType() {
        return this.commerceType;
    }

    public BuyAuthorizationOrderRequest setCommodityType(String commodityType) {
        this.commodityType = commodityType;
        return this;
    }
    public String getCommodityType() {
        return this.commodityType;
    }

    public BuyAuthorizationOrderRequest setEndTimeGMT(Long endTimeGMT) {
        this.endTimeGMT = endTimeGMT;
        return this;
    }
    public Long getEndTimeGMT() {
        return this.endTimeGMT;
    }

    public BuyAuthorizationOrderRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public BuyAuthorizationOrderRequest setInstanceName(String instanceName) {
        this.instanceName = instanceName;
        return this;
    }
    public String getInstanceName() {
        return this.instanceName;
    }

    public BuyAuthorizationOrderRequest setProduceCode(String produceCode) {
        this.produceCode = produceCode;
        return this;
    }
    public String getProduceCode() {
        return this.produceCode;
    }

}
