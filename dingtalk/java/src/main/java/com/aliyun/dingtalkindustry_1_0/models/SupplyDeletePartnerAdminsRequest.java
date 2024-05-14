// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerAdminsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SupplyDeletePartnerAdminsRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerAdminsRequest self = new SupplyDeletePartnerAdminsRequest();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerAdminsRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SupplyDeletePartnerAdminsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
