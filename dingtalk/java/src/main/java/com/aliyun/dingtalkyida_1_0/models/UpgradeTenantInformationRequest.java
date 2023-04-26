// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTenantInformationRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("accountNumber")
    public String accountNumber;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    @NameInMap("commodityType")
    public String commodityType;

    public static UpgradeTenantInformationRequest build(java.util.Map<String, ?> map) throws Exception {
        UpgradeTenantInformationRequest self = new UpgradeTenantInformationRequest();
        return TeaModel.build(map, self);
    }

    public UpgradeTenantInformationRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public UpgradeTenantInformationRequest setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }
    public String getAccountNumber() {
        return this.accountNumber;
    }

    public UpgradeTenantInformationRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public UpgradeTenantInformationRequest setCommodityType(String commodityType) {
        this.commodityType = commodityType;
        return this;
    }
    public String getCommodityType() {
        return this.commodityType;
    }

}
