// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class DeletePermissionResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeletePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeletePermissionResponseBody self = new DeletePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public DeletePermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
