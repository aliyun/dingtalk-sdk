// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SetPermissionInheritanceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SetPermissionInheritanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetPermissionInheritanceResponseBody self = new SetPermissionInheritanceResponseBody();
        return TeaModel.build(map, self);
    }

    public SetPermissionInheritanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
