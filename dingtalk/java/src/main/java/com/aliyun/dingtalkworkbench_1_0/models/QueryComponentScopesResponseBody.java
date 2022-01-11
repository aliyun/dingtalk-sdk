// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class QueryComponentScopesResponseBody extends TeaModel {
    @NameInMap("deptVisibleScopes")
    public java.util.List<Long> deptVisibleScopes;

    // scopes
    @NameInMap("userVisibleScopes")
    public java.util.List<String> userVisibleScopes;

    public static QueryComponentScopesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryComponentScopesResponseBody self = new QueryComponentScopesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryComponentScopesResponseBody setDeptVisibleScopes(java.util.List<Long> deptVisibleScopes) {
        this.deptVisibleScopes = deptVisibleScopes;
        return this;
    }
    public java.util.List<Long> getDeptVisibleScopes() {
        return this.deptVisibleScopes;
    }

    public QueryComponentScopesResponseBody setUserVisibleScopes(java.util.List<String> userVisibleScopes) {
        this.userVisibleScopes = userVisibleScopes;
        return this;
    }
    public java.util.List<String> getUserVisibleScopes() {
        return this.userVisibleScopes;
    }

}
