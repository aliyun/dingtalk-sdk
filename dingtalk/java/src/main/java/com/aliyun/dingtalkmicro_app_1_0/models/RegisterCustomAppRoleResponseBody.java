// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RegisterCustomAppRoleResponseBody extends TeaModel {
    /**
     * <p>角色id</p>
     */
    @NameInMap("roleId")
    public Long roleId;

    /**
     * <p>角色版本号</p>
     */
    @NameInMap("scopeVersion")
    public Long scopeVersion;

    public static RegisterCustomAppRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterCustomAppRoleResponseBody self = new RegisterCustomAppRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterCustomAppRoleResponseBody setRoleId(Long roleId) {
        this.roleId = roleId;
        return this;
    }
    public Long getRoleId() {
        return this.roleId;
    }

    public RegisterCustomAppRoleResponseBody setScopeVersion(Long scopeVersion) {
        this.scopeVersion = scopeVersion;
        return this;
    }
    public Long getScopeVersion() {
        return this.scopeVersion;
    }

}
