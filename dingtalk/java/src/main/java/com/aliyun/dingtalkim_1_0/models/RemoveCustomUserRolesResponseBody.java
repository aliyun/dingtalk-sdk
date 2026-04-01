// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveCustomUserRolesResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RemoveCustomUserRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveCustomUserRolesResponseBody self = new RemoveCustomUserRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveCustomUserRolesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
