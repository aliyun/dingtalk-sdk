// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppRoleInfoRequest extends TeaModel {
    @NameInMap("canManageRole")
    public Boolean canManageRole;

    @NameInMap("newRoleName")
    public String newRoleName;

    @NameInMap("opUserId")
    public String opUserId;

    public static UpdateAppRoleInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppRoleInfoRequest self = new UpdateAppRoleInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAppRoleInfoRequest setCanManageRole(Boolean canManageRole) {
        this.canManageRole = canManageRole;
        return this;
    }
    public Boolean getCanManageRole() {
        return this.canManageRole;
    }

    public UpdateAppRoleInfoRequest setNewRoleName(String newRoleName) {
        this.newRoleName = newRoleName;
        return this;
    }
    public String getNewRoleName() {
        return this.newRoleName;
    }

    public UpdateAppRoleInfoRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
