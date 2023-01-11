// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionRoleMemberResponseBody extends TeaModel {
    /**
     * <p>角色下的成员MAP</p>
     */
    @NameInMap("roleMemberMap")
    public java.util.Map<String, RoleMemberMapValue> roleMemberMap;

    public static QueryPermissionRoleMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionRoleMemberResponseBody self = new QueryPermissionRoleMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPermissionRoleMemberResponseBody setRoleMemberMap(java.util.Map<String, RoleMemberMapValue> roleMemberMap) {
        this.roleMemberMap = roleMemberMap;
        return this;
    }
    public java.util.Map<String, RoleMemberMapValue> getRoleMemberMap() {
        return this.roleMemberMap;
    }

}
