// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTenantInformationRequest extends TeaModel {
    // 访问秘钥
    @NameInMap("accessKey")
    public String accessKey;

    // 调用者unionId
    @NameInMap("callerUnionId")
    public String callerUnionId;

    // 账户号
    @NameInMap("accountNumber")
    public String accountNumber;

    // 商品类型
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

    public UpgradeTenantInformationRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public UpgradeTenantInformationRequest setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }
    public String getAccountNumber() {
        return this.accountNumber;
    }

    public UpgradeTenantInformationRequest setCommodityType(String commodityType) {
        this.commodityType = commodityType;
        return this;
    }
    public String getCommodityType() {
        return this.commodityType;
    }

}
