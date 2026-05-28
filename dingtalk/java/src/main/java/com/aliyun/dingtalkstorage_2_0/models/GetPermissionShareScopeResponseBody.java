// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetPermissionShareScopeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ORG_READ</p>
     */
    @NameInMap("scope")
    public String scope;

    @NameInMap("scopeWithRole")
    public String scopeWithRole;

    public static GetPermissionShareScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionShareScopeResponseBody self = new GetPermissionShareScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPermissionShareScopeResponseBody setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public GetPermissionShareScopeResponseBody setScopeWithRole(String scopeWithRole) {
        this.scopeWithRole = scopeWithRole;
        return this;
    }
    public String getScopeWithRole() {
        return this.scopeWithRole;
    }

}
