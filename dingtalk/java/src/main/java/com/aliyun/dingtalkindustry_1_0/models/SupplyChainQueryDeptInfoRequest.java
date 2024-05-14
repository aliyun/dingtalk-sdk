// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainQueryDeptInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("supplyDeptId")
    public Long supplyDeptId;

    public static SupplyChainQueryDeptInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainQueryDeptInfoRequest self = new SupplyChainQueryDeptInfoRequest();
        return TeaModel.build(map, self);
    }

    public SupplyChainQueryDeptInfoRequest setSupplyDeptId(Long supplyDeptId) {
        this.supplyDeptId = supplyDeptId;
        return this;
    }
    public Long getSupplyDeptId() {
        return this.supplyDeptId;
    }

}
