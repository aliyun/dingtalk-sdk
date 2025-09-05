// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnlockDocByDelegatedPermissionResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UnlockDocByDelegatedPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnlockDocByDelegatedPermissionResponseBody self = new UnlockDocByDelegatedPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public UnlockDocByDelegatedPermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
