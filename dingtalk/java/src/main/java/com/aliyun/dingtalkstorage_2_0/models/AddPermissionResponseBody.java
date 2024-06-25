// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class AddPermissionResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AddPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddPermissionResponseBody self = new AddPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public AddPermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
