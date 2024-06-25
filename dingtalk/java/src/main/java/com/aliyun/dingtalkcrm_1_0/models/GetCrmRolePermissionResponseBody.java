// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmRolePermissionResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldActions")
        public java.util.List<String> fieldActions;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>&quot;DDSelectField-KI5S975E&quot;</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptIdList")
        public java.util.List<Double> deptIdList;

        /**
         * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("ext")
        public GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt ext;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>false 如果是主管，要做逻辑的单独处理。比如如果设置了管理下属或当前部门，只管理他是主管的部门</p>
         */
        @NameInMap("manager")
        public Boolean manager;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10_own 自己负责的 15_all_org 全公司 20_selfDept 同层级 30_selfSubDept 下属的 40_customized 自定义的</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasAuth")
        public Boolean hasAuth;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <ul>
         * <li>操作类型      * 发起：OPERATE_CREATE      * 查看：OPERATE_VIEW      * 编辑：OPERATE_EDIT      * 删除：OPERATE_DELETE      * 打印：OPERATE_PRINT      * 分配：ASSIGN      * 转交：TRANS      * 导入：IMPORT      * 导出：EXPORT</li>
         * </ul>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>可以是员工 uid，可以是部门 ID 等，根据 type 确定</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user：组织成员   dept：部门   tag：标签  org：组织     org_res_admin：组织管理员</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>manager1234</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("defaultRole")
        public Boolean defaultRole;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldScopes")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsFieldScopes> fieldScopes;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("managingScopeList")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsManagingScopeList> managingScopeList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("operateScopes")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsOperateScopes> operateScopes;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PROC-478E50CA-856C-4C08-B806-E664D4CEC8C4</p>
         */
        @NameInMap("resourceId")
        public String resourceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>12821738</p>
         */
        @NameInMap("roleId")
        public Double roleId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("roleMemberList")
        public java.util.List<GetCrmRolePermissionResponseBodyPermissionsRoleMemberList> roleMemberList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>销售权限组</p>
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
