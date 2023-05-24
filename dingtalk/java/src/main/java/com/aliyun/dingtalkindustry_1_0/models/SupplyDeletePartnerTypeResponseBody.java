// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyDeletePartnerTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerTypeResponseBody self = new SupplyDeletePartnerTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerTypeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
