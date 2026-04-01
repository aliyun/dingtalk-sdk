// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomGroupRoleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCustomGroupRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomGroupRoleResponseBody self = new UpdateCustomGroupRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCustomGroupRoleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
