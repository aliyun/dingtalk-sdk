// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerAdminsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyAddPartnerAdminsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerAdminsResponseBody self = new SupplyAddPartnerAdminsResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerAdminsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
