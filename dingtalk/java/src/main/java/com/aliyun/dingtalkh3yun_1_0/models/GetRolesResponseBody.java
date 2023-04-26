// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetRolesResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public GetRolesResponseBodyData data;

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
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("description")
        public String description;

        @NameInMap("groupCode")
        public String groupCode;

        @NameInMap("groupId")
        public String groupId;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("state")
        public String state;

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
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("description")
        public String description;

        @NameInMap("groupId")
        public String groupId;

        @NameInMap("roleCode")
        public String roleCode;

        @NameInMap("roleId")
        public String roleId;

        @NameInMap("roleName")
        public String roleName;

        @NameInMap("state")
        public String state;

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
        @NameInMap("roleGroups")
        public java.util.List<GetRolesResponseBodyDataRoleGroups> roleGroups;

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
