// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddPermissionResponseBody extends TeaModel {
    // 本次操作是否成功
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