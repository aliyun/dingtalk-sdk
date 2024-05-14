// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryRoleTagListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleList")
    public java.util.List<String> roleList;

    public static QueryRoleTagListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRoleTagListResponseBody self = new QueryRoleTagListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRoleTagListResponseBody setRoleList(java.util.List<String> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<String> getRoleList() {
        return this.roleList;
    }

}
