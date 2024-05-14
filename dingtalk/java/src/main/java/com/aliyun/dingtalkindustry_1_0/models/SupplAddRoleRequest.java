// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplAddRoleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("parentRoleGroupId")
    public String parentRoleGroupId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleName")
    public String roleName;

    public static SupplAddRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplAddRoleRequest self = new SupplAddRoleRequest();
        return TeaModel.build(map, self);
    }

    public SupplAddRoleRequest setParentRoleGroupId(String parentRoleGroupId) {
        this.parentRoleGroupId = parentRoleGroupId;
        return this;
    }
    public String getParentRoleGroupId() {
        return this.parentRoleGroupId;
    }

    public SupplAddRoleRequest setRoleName(String roleName) {
        this.roleName = roleName;
        return this;
    }
    public String getRoleName() {
        return this.roleName;
    }

}
