// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class NotifyAuthorizationResultRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("accountNumber")
    public String accountNumber;

    @NameInMap("beginTimeGMT")
    public Long beginTimeGMT;

    @NameInMap("callerUid")
    public String callerUid;

    @NameInMap("chargeType")
    public String chargeType;

    @NameInMap("commerceType")
    public String commerceType;

    @NameInMap("commodityType")
    public String commodityType;

    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("instanceName")
    public String instanceName;

    /**
     * <p>阿里云产品code</p>
     */
    @NameInMap("produceCode")
    public String produceCode;

    public static NotifyAuthorizationResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyAuthorizationResultRequest self = new NotifyAuthorizationResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyAuthorizationResultRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public NotifyAuthorizationResultRequest setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }
    public String getAccountNumber() {
        return this.accountNumber;
    }

    public NotifyAuthorizationResultRequest setBeginTimeGMT(Long beginTimeGMT) {
        this.beginTimeGMT = beginTimeGMT;
        return this;
    }
    public Long getBeginTimeGMT() {
        return this.beginTimeGMT;
    }

    public NotifyAuthorizationResultRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

    public NotifyAuthorizationResultRequest setChargeType(String chargeType) {
        this.chargeType = chargeType;
        return this;
    }
    public String getChargeType() {
        return this.chargeType;
    }

    public NotifyAuthorizationResultRequest setCommerceType(String commerceType) {
        this.commerceType = commerceType;
        return this;
    }
    public String getCommerceType() {
        return this.commerceType;
    }

    public NotifyAuthorizationResultRequest setCommodityType(String commodityType) {
        this.commodityType = commodityType;
        return this;
    }
    public String getCommodityType() {
        return this.commodityType;
    }

    public NotifyAuthorizationResultRequest setEndTimeGMT(Long endTimeGMT) {
        this.endTimeGMT = endTimeGMT;
        return this;
    }
    public Long getEndTimeGMT() {
        return this.endTimeGMT;
    }

    public NotifyAuthorizationResultRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public NotifyAuthorizationResultRequest setInstanceName(String instanceName) {
        this.instanceName = instanceName;
        return this;
    }
    public String getInstanceName() {
        return this.instanceName;
    }

    public NotifyAuthorizationResultRequest setProduceCode(String produceCode) {
        this.produceCode = produceCode;
        return this;
    }
    public String getProduceCode() {
        return this.produceCode;
    }

}
