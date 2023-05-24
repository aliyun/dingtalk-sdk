// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerAdminsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyDeletePartnerAdminsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerAdminsResponseBody self = new SupplyDeletePartnerAdminsResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerAdminsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
