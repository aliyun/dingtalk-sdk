// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppRoleInfoRequest extends TeaModel {
    // 执行用户userId
    @NameInMap("opUserId")
    public String opUserId;

    // 新角色名称
    @NameInMap("newRoleName")
    public String newRoleName;

    public static UpdateAppRoleInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppRoleInfoRequest self = new UpdateAppRoleInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAppRoleInfoRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public UpdateAppRoleInfoRequest setNewRoleName(String newRoleName) {
        this.newRoleName = newRoleName;
        return this;
    }
    public String getNewRoleName() {
        return this.newRoleName;
    }

}
