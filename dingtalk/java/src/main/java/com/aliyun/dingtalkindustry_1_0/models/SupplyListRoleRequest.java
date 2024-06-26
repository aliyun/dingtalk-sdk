// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListRoleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("parentRoleId")
    public String parentRoleId;

    public static SupplyListRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyListRoleRequest self = new SupplyListRoleRequest();
        return TeaModel.build(map, self);
    }

    public SupplyListRoleRequest setParentRoleId(String parentRoleId) {
        this.parentRoleId = parentRoleId;
        return this;
    }
    public String getParentRoleId() {
        return this.parentRoleId;
    }

}
