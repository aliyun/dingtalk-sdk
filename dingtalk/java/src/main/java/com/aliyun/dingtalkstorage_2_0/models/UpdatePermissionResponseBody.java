// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdatePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionResponseBody self = new UpdatePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
