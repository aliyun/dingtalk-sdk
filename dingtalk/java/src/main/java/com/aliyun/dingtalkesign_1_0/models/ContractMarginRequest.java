// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ContractMarginRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    public static ContractMarginRequest build(java.util.Map<String, ?> map) throws Exception {
        ContractMarginRequest self = new ContractMarginRequest();
        return TeaModel.build(map, self);
    }

    public ContractMarginRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

}
