// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmRolePermissionResponseBody extends TeaModel {
    /**
     * <p>CRM表单权限配置</p>
     */
    @NameInMap("permissions")
    public java.util.List<GetCrmRolePermissionResponseBodyPermissions> permissions;

    public static GetCrmRolePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCrmRolePermissionResponseBody self = new GetCrmRolePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCrmRolePermissionResponseBody setPermissions(java.util.List<GetCrmRolePermissionResponseBodyPermissions> permissions) {
        this.permissions = permissions;
        return this;
    }
    public java.util.List<GetCrmRolePermissionResponseBodyPermissions> getPermissions() {
        return this.permissions;
    }

    public static class GetCrmRolePermissionResponseBodyPermissionsFieldScopes extends TeaModel {
        /**
         * <p>字段权限点</p>
         */
        @NameInMap("fieldActions")
        public java.util.List<String> fieldActions;

        /**
         * <p>字段id</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        public static GetCrmRolePermissionResponseBodyPermissionsFieldScopes build(java.util.Map<String, ?> map) throws Exception {
            GetCrmRolePermissionResponseBodyPermissionsFieldScopes self = new GetCrmRolePermissionResponseBodyPermissionsFieldScopes();
            return TeaModel.build(map, self);
        }

        public GetCrmRolePermissionResponseBodyPermissionsFieldScopes setFieldActions(java.util.List<String> fieldActions) {
            this.fieldActions = fieldActions;
            return this;
        }
        public java.util.List<String> getFieldActions() {
            return this.fieldActions;
        }

        public GetCrmRolePermissionResponseBodyPermissionsFieldScopes setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt extends TeaModel {
        /**
         * <p>管理部门列表</p>
         */
        @NameInMap("deptIdList")
        public java.util.List<Double> deptIdList;

        /**
         * <p>管理员工列表</p>
         */
        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        public static GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt build(java.util.Map<String, ?> map) throws Exception {
            GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt self = new GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt();
            return TeaModel.build(map, self);
        }

        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt setDeptIdList(java.util.List<Double> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Double> getDeptIdList() {
            return this.deptIdList;
        }

        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt setUserIdList(java.util.List<String> userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public java.util.List<String> getUserIdList() {
            return this.userIdList;
        }

    }

    public static class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList extends TeaModel {
        /**
         * <p>扩展信息</p>
         */
        @NameInMap("ext")
        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt ext;

        /**
         * <p>是否是主管</p>
         */
        @NameInMap("manager")
        public Boolean manager;

        /**
         * <p>管理范围类型</p>
         */
        @NameInMap("type")
        public String type;

        public static GetCrmRolePermissionResponseBodyPermissionsManagingScopeList build(java.util.Map<String, ?> map) throws Exception {
            GetCrmRolePermissionResponseBodyPermissionsManagingScopeList self = new GetCrmRolePermissionResponseBodyPermissionsManagingScopeList();
            return TeaModel.build(map, self);
        }

        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeList setExt(GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt ext) {
            this.ext = ext;
            return this;
        }
        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt getExt() {
            return this.ext;
        }

        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeList setManager(Boolean manager) {
            this.manager = manager;
            return this;
        }
        public Boolean getManager() {
            return this.manager;
        }

        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetCrmRolePermissionResponseBodyPermissionsOperateScopes extends TeaModel {
        /**
         * <p>是否有权限</p>
         */
        @NameInMap("hasAuth")
        public Boolean hasAuth;

        /**
         * <p>操作范围类型</p>
         */
        @NameInMap("type")
        public String type;

        public static GetCrmRolePermissionResponseBodyPermissionsOperateScopes build(java.util.Map<String, ?> map) throws Exception {
            GetCrmRolePermissionResponseBodyPermissionsOperateScopes self = new GetCrmRolePermissionResponseBodyPermissionsOperateScopes();
            return TeaModel.build(map, self);
        }

        public GetCrmRolePermissionResponseBodyPermissionsOperateScopes setHasAuth(Boolean hasAuth) {
            this.hasAuth = hasAuth;
            return this;
        }
        public Boolean getHasAuth() {
            return this.hasAuth;
        }

        public GetCrmRolePermissionResponseBodyPermissionsOperateScopes setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList extends TeaModel {
        /**
         * <p>角色值</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>角色名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>角色类型</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>角色的userId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetCrmRolePermissionResponseBodyPermissionsRoleMemberList build(java.util.Map<String, ?> map) throws Exception {
            GetCrmRolePermissionResponseBodyPermissionsRoleMemberList self = new GetCrmRolePermissionResponseBodyPermissionsRoleMemberList();
            return TeaModel.build(map, self);
        }

        public GetCrmRolePermissionResponseBodyPermissionsRoleMemberList setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public GetCrmRolePermissionResponseBodyPermissionsRoleMemberList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCrmRolePermissionResponseBodyPermissionsRoleMemberList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetCrmRolePermissionResponseBodyPermissionsRoleMemberList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetCrmRolePermissionResponseBodyPermissions extends TeaModel {
        /**
         * <p>是否是默认权限</p>
         */
        @NameInMap("defaultRole")
        public Boolean defaultRole;

        /**
         * <p>字段权限</p>
         */
        @NameInMap("fieldScopes")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> fieldScopes;

        /**
         * <p>权限组适用范围配置</p>
         */
        @NameInMap("managingScopeList")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> managingScopeList;

        /**
         * <p>操作范围</p>
         */
        @NameInMap("operateScopes")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> operateScopes;

        /**
         * <p>资源id</p>
         */
        @NameInMap("resourceId")
        public String resourceId;

        /**
         * <p>权限组id</p>
         */
        @NameInMap("roleId")
        public Double roleId;

        /**
         * <p>权限组配置</p>
         */
        @NameInMap("roleMemberList")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> roleMemberList;

        /**
         * <p>权限组名称</p>
         */
        @NameInMap("roleName")
        public String roleName;

        public static GetCrmRolePermissionResponseBodyPermissions build(java.util.Map<String, ?> map) throws Exception {
            GetCrmRolePermissionResponseBodyPermissions self = new GetCrmRolePermissionResponseBodyPermissions();
            return TeaModel.build(map, self);
        }

        public GetCrmRolePermissionResponseBodyPermissions setDefaultRole(Boolean defaultRole) {
            this.defaultRole = defaultRole;
            return this;
        }
        public Boolean getDefaultRole() {
            return this.defaultRole;
        }

        public GetCrmRolePermissionResponseBodyPermissions setFieldScopes(java.util.List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> fieldScopes) {
            this.fieldScopes = fieldScopes;
            return this;
        }
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> getFieldScopes() {
            return this.fieldScopes;
        }

        public GetCrmRolePermissionResponseBodyPermissions setManagingScopeList(java.util.List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> managingScopeList) {
            this.managingScopeList = managingScopeList;
            return this;
        }
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> getManagingScopeList() {
            return this.managingScopeList;
        }

        public GetCrmRolePermissionResponseBodyPermissions setOperateScopes(java.util.List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> operateScopes) {
            this.operateScopes = operateScopes;
            return this;
        }
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> getOperateScopes() {
            return this.operateScopes;
        }

        public GetCrmRolePermissionResponseBodyPermissions setResourceId(String resourceId) {
            this.resourceId = resourceId;
            return this;
        }
        public String getResourceId() {
            return this.resourceId;
        }

        public GetCrmRolePermissionResponseBodyPermissions setRoleId(Double roleId) {
            this.roleId = roleId;
            return this;
        }
        public Double getRoleId() {
            return this.roleId;
        }

        public GetCrmRolePermissionResponseBodyPermissions setRoleMemberList(java.util.List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> roleMemberList) {
            this.roleMemberList = roleMemberList;
            return this;
        }
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> getRoleMemberList() {
            return this.roleMemberList;
        }

        public GetCrmRolePermissionResponseBodyPermissions setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

}
