// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerManagersResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyDeletePartnerManagersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerManagersResponseBody self = new SupplyDeletePartnerManagersResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerManagersResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
