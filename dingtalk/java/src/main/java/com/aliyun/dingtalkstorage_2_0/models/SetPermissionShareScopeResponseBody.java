// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SetPermissionShareScopeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SetPermissionShareScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetPermissionShareScopeResponseBody self = new SetPermissionShareScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public SetPermissionShareScopeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
