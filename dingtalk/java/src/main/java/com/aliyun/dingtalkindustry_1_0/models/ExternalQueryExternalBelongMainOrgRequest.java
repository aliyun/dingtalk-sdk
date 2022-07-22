// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalBelongMainOrgRequest extends TeaModel {
    // 外部组织类型
    @NameInMap("externalType")
    public String externalType;

    public static ExternalQueryExternalBelongMainOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalBelongMainOrgRequest self = new ExternalQueryExternalBelongMainOrgRequest();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalBelongMainOrgRequest setExternalType(String externalType) {
        this.externalType = externalType;
        return this;
    }
    public String getExternalType() {
        return this.externalType;
    }

}
