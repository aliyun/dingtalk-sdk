// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteAppRoleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static DeleteAppRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteAppRoleRequest self = new DeleteAppRoleRequest();
        return TeaModel.build(map, self);
    }

    public DeleteAppRoleRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
