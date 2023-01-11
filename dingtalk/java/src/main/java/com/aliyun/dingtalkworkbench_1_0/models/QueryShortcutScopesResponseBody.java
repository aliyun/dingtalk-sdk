// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class QueryShortcutScopesResponseBody extends TeaModel {
    @NameInMap("deptVisibleScopes")
    public java.util.List<Long> deptVisibleScopes;

    /**
     * <p>errorMsg</p>
     */
    @NameInMap("userVisibleScopes")
    public java.util.List<String> userVisibleScopes;

    public static QueryShortcutScopesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryShortcutScopesResponseBody self = new QueryShortcutScopesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryShortcutScopesResponseBody setDeptVisibleScopes(java.util.List<Long> deptVisibleScopes) {
        this.deptVisibleScopes = deptVisibleScopes;
        return this;
    }
    public java.util.List<Long> getDeptVisibleScopes() {
        return this.deptVisibleScopes;
    }

    public QueryShortcutScopesResponseBody setUserVisibleScopes(java.util.List<String> userVisibleScopes) {
        this.userVisibleScopes = userVisibleScopes;
        return this;
    }
    public java.util.List<String> getUserVisibleScopes() {
        return this.userVisibleScopes;
    }

}
