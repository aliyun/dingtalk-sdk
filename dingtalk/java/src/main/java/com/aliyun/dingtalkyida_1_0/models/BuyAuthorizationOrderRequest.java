// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyAuthorizationOrderRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>hexaaaa</p>
     */
    @NameInMap("accessKey")
    public String accessKey;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("accountNumber")
    public String accountNumber;

    /**
     * <strong>example:</strong>
     * <p>1234123423459</p>
     */
    @NameInMap("beginTimeGMT")
    public Long beginTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>44234122</p>
     */
    @NameInMap("callerUnionId")
    public String callerUnionId;

    /**
     * <strong>example:</strong>
     * <p>subscribe</p>
     */
    @NameInMap("chargeType")
    public String chargeType;

    /**
     * <strong>example:</strong>
     * <p>subscribe</p>
     */
    @NameInMap("commerceType")
    public String commerceType;

    /**
     * <strong>example:</strong>
     * <p>Business</p>
     */
    @NameInMap("commodityType")
    public String commodityType;

    /**
     * <strong>example:</strong>
     * <p>1023451234123</p>
     */
    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>12</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>A发起的实例</p>
     */
    @NameInMap("instanceName")
    public String instanceName;

    /**
     * <strong>example:</strong>
     * <p>yun-1234</p>
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
