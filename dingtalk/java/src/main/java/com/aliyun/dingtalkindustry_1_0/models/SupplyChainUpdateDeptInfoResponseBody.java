// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainUpdateDeptInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyChainUpdateDeptInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainUpdateDeptInfoResponseBody self = new SupplyChainUpdateDeptInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyChainUpdateDeptInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
