// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdatePartnerTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyUpdatePartnerTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdatePartnerTypeResponseBody self = new SupplyUpdatePartnerTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyUpdatePartnerTypeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
