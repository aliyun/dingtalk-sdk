// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainDeleteDeptRequest extends TeaModel {
    @NameInMap("supplyDeptId")
    public Long supplyDeptId;

    public static SupplyChainDeleteDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainDeleteDeptRequest self = new SupplyChainDeleteDeptRequest();
        return TeaModel.build(map, self);
    }

    public SupplyChainDeleteDeptRequest setSupplyDeptId(Long supplyDeptId) {
        this.supplyDeptId = supplyDeptId;
        return this;
    }
    public Long getSupplyDeptId() {
        return this.supplyDeptId;
    }

}
