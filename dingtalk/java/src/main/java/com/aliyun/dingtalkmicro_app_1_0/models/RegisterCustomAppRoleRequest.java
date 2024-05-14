// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RegisterCustomAppRoleRequest extends TeaModel {
    @NameInMap("canManageRole")
    public Boolean canManageRole;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleName")
    public String roleName;

    public static RegisterCustomAppRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterCustomAppRoleRequest self = new RegisterCustomAppRoleRequest();
        return TeaModel.build(map, self);
    }

    public RegisterCustomAppRoleRequest setCanManageRole(Boolean canManageRole) {
        this.canManageRole = canManageRole;
        return this;
    }
    public Boolean getCanManageRole() {
        return this.canManageRole;
    }

    public RegisterCustomAppRoleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public RegisterCustomAppRoleRequest setRoleName(String roleName) {
        this.roleName = roleName;
        return this;
    }
    public String getRoleName() {
        return this.roleName;
    }

}
