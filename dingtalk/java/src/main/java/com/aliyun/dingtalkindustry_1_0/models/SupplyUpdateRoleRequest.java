// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdateRoleRequest extends TeaModel {
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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleName")
    public String roleName;

    public static SupplyUpdateRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdateRoleRequest self = new SupplyUpdateRoleRequest();
        return TeaModel.build(map, self);
    }

    public SupplyUpdateRoleRequest setIsRoleGroup(Boolean isRoleGroup) {
        this.isRoleGroup = isRoleGroup;
        return this;
    }
    public Boolean getIsRoleGroup() {
        return this.isRoleGroup;
    }

    public SupplyUpdateRoleRequest setRoleId(String roleId) {
        this.roleId = roleId;
        return this;
    }
    public String getRoleId() {
        return this.roleId;
    }

    public SupplyUpdateRoleRequest setRoleName(String roleName) {
        this.roleName = roleName;
        return this;
    }
    public String getRoleName() {
        return this.roleName;
    }

}
