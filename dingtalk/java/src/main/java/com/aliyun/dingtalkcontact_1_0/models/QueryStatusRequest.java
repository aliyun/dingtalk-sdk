// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryStatusRequest extends TeaModel {
    @NameInMap("permissionCode")
    public String permissionCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userIdXXX</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryStatusRequest self = new QueryStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryStatusRequest setPermissionCode(String permissionCode) {
        this.permissionCode = permissionCode;
        return this;
    }
    public String getPermissionCode() {
        return this.permissionCode;
    }

    public QueryStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
