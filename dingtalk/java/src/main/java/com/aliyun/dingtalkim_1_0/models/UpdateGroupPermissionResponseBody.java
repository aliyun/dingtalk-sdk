// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupPermissionResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateGroupPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupPermissionResponseBody self = new UpdateGroupPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGroupPermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
