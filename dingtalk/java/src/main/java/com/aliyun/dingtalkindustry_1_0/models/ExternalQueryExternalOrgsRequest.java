// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalOrgsRequest extends TeaModel {
    @NameInMap("externalType")
    public String externalType;

    public static ExternalQueryExternalOrgsRequest build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalOrgsRequest self = new ExternalQueryExternalOrgsRequest();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalOrgsRequest setExternalType(String externalType) {
        this.externalType = externalType;
        return this;
    }
    public String getExternalType() {
        return this.externalType;
    }

}
