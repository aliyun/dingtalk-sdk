// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainDeleteDeptResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyChainDeleteDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainDeleteDeptResponseBody self = new SupplyChainDeleteDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyChainDeleteDeptResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
