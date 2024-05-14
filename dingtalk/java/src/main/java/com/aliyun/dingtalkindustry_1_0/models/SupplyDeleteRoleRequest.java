// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeleteRoleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isRoleGroup")
    public Boolean isRoleGroup;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleId")
    public String roleId;

    public static SupplyDeleteRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeleteRoleRequest self = new SupplyDeleteRoleRequest();
        return TeaModel.build(map, self);
    }

    public SupplyDeleteRoleRequest setIsRoleGroup(Boolean isRoleGroup) {
        this.isRoleGroup = isRoleGroup;
        return this;
    }
    public Boolean getIsRoleGroup() {
        return this.isRoleGroup;
    }

    public SupplyDeleteRoleRequest setRoleId(String roleId) {
        this.roleId = roleId;
        return this;
    }
    public String getRoleId() {
        return this.roleId;
    }

}
