// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListSubDeptRequest extends TeaModel {
    @NameInMap("supplyDeptId")
    public Long supplyDeptId;

    public static SupplyListSubDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyListSubDeptRequest self = new SupplyListSubDeptRequest();
        return TeaModel.build(map, self);
    }

    public SupplyListSubDeptRequest setSupplyDeptId(Long supplyDeptId) {
        this.supplyDeptId = supplyDeptId;
        return this;
    }
    public Long getSupplyDeptId() {
        return this.supplyDeptId;
    }

}
