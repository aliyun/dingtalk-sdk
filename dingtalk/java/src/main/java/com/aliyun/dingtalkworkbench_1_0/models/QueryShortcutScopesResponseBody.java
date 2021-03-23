// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class QueryShortcutScopesResponseBody extends TeaModel {
    // errorMsg
    @NameInMap("userVisibleScopes")
    public java.util.List<String> userVisibleScopes;

    @NameInMap("deptVisibleScopes")
    public java.util.List<Float> deptVisibleScopes;

    public static QueryShortcutScopesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryShortcutScopesResponseBody self = new QueryShortcutScopesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryShortcutScopesResponseBody setUserVisibleScopes(java.util.List<String> userVisibleScopes) {
        this.userVisibleScopes = userVisibleScopes;
        return this;
    }
    public java.util.List<String> getUserVisibleScopes() {
        return this.userVisibleScopes;
    }

    public QueryShortcutScopesResponseBody setDeptVisibleScopes(java.util.List<Float> deptVisibleScopes) {
        this.deptVisibleScopes = deptVisibleScopes;
        return this;
    }
    public java.util.List<Float> getDeptVisibleScopes() {
        return this.deptVisibleScopes;
    }

}
