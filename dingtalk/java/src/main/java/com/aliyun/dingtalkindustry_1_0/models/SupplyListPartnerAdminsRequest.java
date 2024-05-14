// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerAdminsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static SupplyListPartnerAdminsRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerAdminsRequest self = new SupplyListPartnerAdminsRequest();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerAdminsRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
