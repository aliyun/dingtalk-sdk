// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalAppOrgsRequest extends TeaModel {
    @NameInMap("externalType")
    public String externalType;

    public static ExternalQueryExternalAppOrgsRequest build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalAppOrgsRequest self = new ExternalQueryExternalAppOrgsRequest();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalAppOrgsRequest setExternalType(String externalType) {
        this.externalType = externalType;
        return this;
    }
    public String getExternalType() {
        return this.externalType;
    }

}
