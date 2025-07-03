// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryRolesResponseBody extends TeaModel {
    @NameInMap("roleMap")
    public java.util.Map<String, java.util.List<RoleMapValue>> roleMap;

    public static BatchQueryRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryRolesResponseBody self = new BatchQueryRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryRolesResponseBody setRoleMap(java.util.Map<String, java.util.List<RoleMapValue>> roleMap) {
        this.roleMap = roleMap;
        return this;
    }
    public java.util.Map<String, java.util.List<RoleMapValue>> getRoleMap() {
        return this.roleMap;
    }

}
