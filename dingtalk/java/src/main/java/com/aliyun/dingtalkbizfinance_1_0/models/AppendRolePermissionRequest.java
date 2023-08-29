// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class AppendRolePermissionRequest extends TeaModel {
    @NameInMap("rolePermissionItemList")
    public java.util.List<AppendRolePermissionRequestRolePermissionItemList> rolePermissionItemList;

    @NameInMap("userId")
    public String userId;

    public static AppendRolePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        AppendRolePermissionRequest self = new AppendRolePermissionRequest();
        return TeaModel.build(map, self);
    }

    public AppendRolePermissionRequest setRolePermissionItemList(java.util.List<AppendRolePermissionRequestRolePermissionItemList> rolePermissionItemList) {
        this.rolePermissionItemList = rolePermissionItemList;
        return this;
    }
    public java.util.List<AppendRolePermissionRequestRolePermissionItemList> getRolePermissionItemList() {
        return this.rolePermissionItemList;
    }

    public AppendRolePermissionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AppendRolePermissionRequestRolePermissionItemListPermissionList extends TeaModel {
        @NameInMap("actionIdList")
        public java.util.List<String> actionIdList;

        @NameInMap("resourceIdentity")
        public String resourceIdentity;

        public static AppendRolePermissionRequestRolePermissionItemListPermissionList build(java.util.Map<String, ?> map) throws Exception {
            AppendRolePermissionRequestRolePermissionItemListPermissionList self = new AppendRolePermissionRequestRolePermissionItemListPermissionList();
            return TeaModel.build(map, self);
        }

        public AppendRolePermissionRequestRolePermissionItemListPermissionList setActionIdList(java.util.List<String> actionIdList) {
            this.actionIdList = actionIdList;
            return this;
        }
        public java.util.List<String> getActionIdList() {
            return this.actionIdList;
        }

        public AppendRolePermissionRequestRolePermissionItemListPermissionList setResourceIdentity(String resourceIdentity) {
            this.resourceIdentity = resourceIdentity;
            return this;
        }
        public String getResourceIdentity() {
            return this.resourceIdentity;
        }

    }

    public static class AppendRolePermissionRequestRolePermissionItemList extends TeaModel {
        @NameInMap("permissionList")
        public java.util.List<AppendRolePermissionRequestRolePermissionItemListPermissionList> permissionList;

        @NameInMap("roleCode")
        public String roleCode;

        public static AppendRolePermissionRequestRolePermissionItemList build(java.util.Map<String, ?> map) throws Exception {
            AppendRolePermissionRequestRolePermissionItemList self = new AppendRolePermissionRequestRolePermissionItemList();
            return TeaModel.build(map, self);
        }

        public AppendRolePermissionRequestRolePermissionItemList setPermissionList(java.util.List<AppendRolePermissionRequestRolePermissionItemListPermissionList> permissionList) {
            this.permissionList = permissionList;
            return this;
        }
        public java.util.List<AppendRolePermissionRequestRolePermissionItemListPermissionList> getPermissionList() {
            return this.permissionList;
        }

        public AppendRolePermissionRequestRolePermissionItemList setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
