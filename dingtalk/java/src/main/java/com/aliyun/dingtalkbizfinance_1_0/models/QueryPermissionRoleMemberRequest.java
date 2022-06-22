// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionRoleMemberRequest extends TeaModel {
    // 角色的唯一标识列表
    @NameInMap("roleCodeList")
    public java.util.List<String> roleCodeList;

    public static QueryPermissionRoleMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionRoleMemberRequest self = new QueryPermissionRoleMemberRequest();
        return TeaModel.build(map, self);
    }

    public QueryPermissionRoleMemberRequest setRoleCodeList(java.util.List<String> roleCodeList) {
        this.roleCodeList = roleCodeList;
        return this;
    }
    public java.util.List<String> getRoleCodeList() {
        return this.roleCodeList;
    }

}
