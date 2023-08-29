// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class AppendRolePermissionShrinkRequest extends TeaModel {
    @NameInMap("rolePermissionItemList")
    public String rolePermissionItemListShrink;

    @NameInMap("userId")
    public String userId;

    public static AppendRolePermissionShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        AppendRolePermissionShrinkRequest self = new AppendRolePermissionShrinkRequest();
        return TeaModel.build(map, self);
    }

    public AppendRolePermissionShrinkRequest setRolePermissionItemListShrink(String rolePermissionItemListShrink) {
        this.rolePermissionItemListShrink = rolePermissionItemListShrink;
        return this;
    }
    public String getRolePermissionItemListShrink() {
        return this.rolePermissionItemListShrink;
    }

    public AppendRolePermissionShrinkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
