// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerManagersRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>56781233</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static SupplyListPartnerManagersRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerManagersRequest self = new SupplyListPartnerManagersRequest();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerManagersRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
