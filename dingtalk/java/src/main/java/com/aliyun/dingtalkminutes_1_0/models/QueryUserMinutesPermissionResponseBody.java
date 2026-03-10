// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUserMinutesPermissionResponseBody extends TeaModel {
    @NameInMap("hasPermission")
    public Boolean hasPermission;

    /**
     * <p>角色类型：manager-管理员, owner-所有者, editor-可编辑, read_download-可查看/下载, read-仅查看, none-无权限</p>
     */
    @NameInMap("roleType")
    public String roleType;

    public static QueryUserMinutesPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserMinutesPermissionResponseBody self = new QueryUserMinutesPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserMinutesPermissionResponseBody setHasPermission(Boolean hasPermission) {
        this.hasPermission = hasPermission;
        return this;
    }
    public Boolean getHasPermission() {
        return this.hasPermission;
    }

    public QueryUserMinutesPermissionResponseBody setRoleType(String roleType) {
        this.roleType = roleType;
        return this;
    }
    public String getRoleType() {
        return this.roleType;
    }

}
