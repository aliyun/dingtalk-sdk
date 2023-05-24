// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerManagersResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyAddPartnerManagersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerManagersResponseBody self = new SupplyAddPartnerManagersResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerManagersResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
