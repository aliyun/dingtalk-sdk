// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTenantInformationRequest extends TeaModel {
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
     * <p>44234122</p>
     */
    @NameInMap("callerUnionId")
    public String callerUnionId;

    /**
     * <strong>example:</strong>
     * <p>Business</p>
     */
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
