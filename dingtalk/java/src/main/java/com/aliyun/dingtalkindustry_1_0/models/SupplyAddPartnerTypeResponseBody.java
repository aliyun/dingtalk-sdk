// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    public static SupplyAddPartnerTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerTypeResponseBody self = new SupplyAddPartnerTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerTypeResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
