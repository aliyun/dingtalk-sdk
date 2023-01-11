// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetRolesResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("data")
    public GetRolesResponseBodyData data;

    /**
     * <p>提示信息</p>
     */
    @NameInMap("message")
    public String message;

    public static GetRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRolesResponseBody self = new GetRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRolesResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetRolesResponseBody setData(GetRolesResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetRolesResponseBodyData getData() {
        return this.data;
    }

    public GetRolesResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetRolesResponseBodyDataRoleGroups extends TeaModel {
        /**
         * <p>所属企业id</p>
         */
        @NameInMap("companyId")
        public String companyId;

        /**
         * <p>描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>组编码</p>
         */
        @NameInMap("groupCode")
        public String groupCode;

        /**
         * <p>组id</p>
         */
        @NameInMap("groupId")
        public String groupId;

        /**
         * <p>组名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <p>状态。Active=激活、Inactive=未激活，Unspecified=未指定状态</p>
         */
        @NameInMap("state")
        public String state;

        /**
         * <p>可见性。All=全部可见、Normal=普通可见、OnlyAdmin=只有管理的时候可见、OnlyOrganization=本组织范围可见</p>
         */
        @NameInMap("visibility")
        public String visibility;

        public static GetRolesResponseBodyDataRoleGroups build(java.util.Map<String, ?> map) throws Exception {
            GetRolesResponseBodyDataRoleGroups self = new GetRolesResponseBodyDataRoleGroups();
            return TeaModel.build(map, self);
        }

        public GetRolesResponseBodyDataRoleGroups setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public GetRolesResponseBodyDataRoleGroups setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetRolesResponseBodyDataRoleGroups setGroupCode(String groupCode) {
            this.groupCode = groupCode;
            return this;
        }
        public String getGroupCode() {
            return this.groupCode;
        }

        public GetRolesResponseBodyDataRoleGroups setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public GetRolesResponseBodyDataRoleGroups setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetRolesResponseBodyDataRoleGroups setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public GetRolesResponseBodyDataRoleGroups setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

    public static class GetRolesResponseBodyDataRoles extends TeaModel {
        /**
         * <p>所属企业id</p>
         */
        @NameInMap("companyId")
        public String companyId;

        /**
         * <p>描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>所属的角色组id</p>
         */
        @NameInMap("groupId")
        public String groupId;

        /**
         * <p>角色编码</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        /**
         * <p>角色id</p>
         */
        @NameInMap("roleId")
        public String roleId;

        /**
         * <p>角色名称</p>
         */
        @NameInMap("roleName")
        public String roleName;

        /**
         * <p>状态。Active=激活、Inactive=未激活，Unspecified=未指定状态</p>
         */
        @NameInMap("state")
        public String state;

        /**
         * <p>可见性。All=全部可见、Normal=普通可见、OnlyAdmin=只有管理的时候可见、OnlyOrganization=本组织范围可见</p>
         */
        @NameInMap("visibility")
        public String visibility;

        public static GetRolesResponseBodyDataRoles build(java.util.Map<String, ?> map) throws Exception {
            GetRolesResponseBodyDataRoles self = new GetRolesResponseBodyDataRoles();
            return TeaModel.build(map, self);
        }

        public GetRolesResponseBodyDataRoles setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public GetRolesResponseBodyDataRoles setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetRolesResponseBodyDataRoles setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public GetRolesResponseBodyDataRoles setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public GetRolesResponseBodyDataRoles setRoleId(String roleId) {
            this.roleId = roleId;
            return this;
        }
        public String getRoleId() {
            return this.roleId;
        }

        public GetRolesResponseBodyDataRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public GetRolesResponseBodyDataRoles setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public GetRolesResponseBodyDataRoles setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

    public static class GetRolesResponseBodyData extends TeaModel {
        /**
         * <p>角色组数组</p>
         */
        @NameInMap("roleGroups")
        public java.util.List<GetRolesResponseBodyDataRoleGroups> roleGroups;

        /**
         * <p>角色数组</p>
         */
        @NameInMap("roles")
        public java.util.List<GetRolesResponseBodyDataRoles> roles;

        public static GetRolesResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetRolesResponseBodyData self = new GetRolesResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetRolesResponseBodyData setRoleGroups(java.util.List<GetRolesResponseBodyDataRoleGroups> roleGroups) {
            this.roleGroups = roleGroups;
            return this;
        }
        public java.util.List<GetRolesResponseBodyDataRoleGroups> getRoleGroups() {
            return this.roleGroups;
        }

        public GetRolesResponseBodyData setRoles(java.util.List<GetRolesResponseBodyDataRoles> roles) {
            this.roles = roles;
            return this;
        }
        public java.util.List<GetRolesResponseBodyDataRoles> getRoles() {
            return this.roles;
        }

    }

}
