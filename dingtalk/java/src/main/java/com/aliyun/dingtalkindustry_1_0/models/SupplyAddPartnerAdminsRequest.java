// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerAdminsRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("userId")
    public String userId;

    public static SupplyAddPartnerAdminsRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerAdminsRequest self = new SupplyAddPartnerAdminsRequest();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerAdminsRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SupplyAddPartnerAdminsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
