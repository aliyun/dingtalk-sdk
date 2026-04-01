// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveCustomGroupRoleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RemoveCustomGroupRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveCustomGroupRoleResponseBody self = new RemoveCustomGroupRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveCustomGroupRoleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
