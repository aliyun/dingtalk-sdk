// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpdateCloudAccountInformationRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("accountNumber")
    public String accountNumber;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    @NameInMap("commodityType")
    public String commodityType;

    public static UpdateCloudAccountInformationRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCloudAccountInformationRequest self = new UpdateCloudAccountInformationRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCloudAccountInformationRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public UpdateCloudAccountInformationRequest setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }
    public String getAccountNumber() {
        return this.accountNumber;
    }

    public UpdateCloudAccountInformationRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public UpdateCloudAccountInformationRequest setCommodityType(String commodityType) {
        this.commodityType = commodityType;
        return this;
    }
    public String getCommodityType() {
        return this.commodityType;
    }

}
