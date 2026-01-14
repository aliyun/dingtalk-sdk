// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryDocAllRolesResponseBody extends TeaModel {
    @NameInMap("allRoles")
    public java.util.List<QueryDocAllRolesResponseBodyAllRoles> allRoles;

    @NameInMap("defaultRole")
    public QueryDocAllRolesResponseBodyDefaultRole defaultRole;

    @NameInMap("enabled")
    public Boolean enabled;

    @NameInMap("systemRoles")
    public java.util.List<Long> systemRoles;

    public static QueryDocAllRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDocAllRolesResponseBody self = new QueryDocAllRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDocAllRolesResponseBody setAllRoles(java.util.List<QueryDocAllRolesResponseBodyAllRoles> allRoles) {
        this.allRoles = allRoles;
        return this;
    }
    public java.util.List<QueryDocAllRolesResponseBodyAllRoles> getAllRoles() {
        return this.allRoles;
    }

    public QueryDocAllRolesResponseBody setDefaultRole(QueryDocAllRolesResponseBodyDefaultRole defaultRole) {
        this.defaultRole = defaultRole;
        return this;
    }
    public QueryDocAllRolesResponseBodyDefaultRole getDefaultRole() {
        return this.defaultRole;
    }

    public QueryDocAllRolesResponseBody setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

    public QueryDocAllRolesResponseBody setSystemRoles(java.util.List<Long> systemRoles) {
        this.systemRoles = systemRoles;
        return this;
    }
    public java.util.List<Long> getSystemRoles() {
        return this.systemRoles;
    }

    public static class QueryDocAllRolesResponseBodyAllRolesMembers extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberIdBelongOrgId")
        public Long memberIdBelongOrgId;

        @NameInMap("memberType")
        public String memberType;

        @NameInMap("name")
        public String name;

        public static QueryDocAllRolesResponseBodyAllRolesMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryDocAllRolesResponseBodyAllRolesMembers self = new QueryDocAllRolesResponseBodyAllRolesMembers();
            return TeaModel.build(map, self);
        }

        public QueryDocAllRolesResponseBodyAllRolesMembers setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public QueryDocAllRolesResponseBodyAllRolesMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public QueryDocAllRolesResponseBodyAllRolesMembers setMemberIdBelongOrgId(Long memberIdBelongOrgId) {
            this.memberIdBelongOrgId = memberIdBelongOrgId;
            return this;
        }
        public Long getMemberIdBelongOrgId() {
            return this.memberIdBelongOrgId;
        }

        public QueryDocAllRolesResponseBodyAllRolesMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public QueryDocAllRolesResponseBodyAllRolesMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryDocAllRolesResponseBodyAllRolesRoleSubRoles extends TeaModel {
        @NameInMap("authLevel")
        public Integer authLevel;

        @NameInMap("bizType")
        public Integer bizType;

        @NameInMap("config")
        public String config;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("id")
        public String id;

        public static QueryDocAllRolesResponseBodyAllRolesRoleSubRoles build(java.util.Map<String, ?> map) throws Exception {
            QueryDocAllRolesResponseBodyAllRolesRoleSubRoles self = new QueryDocAllRolesResponseBodyAllRolesRoleSubRoles();
            return TeaModel.build(map, self);
        }

        public QueryDocAllRolesResponseBodyAllRolesRoleSubRoles setAuthLevel(Integer authLevel) {
            this.authLevel = authLevel;
            return this;
        }
        public Integer getAuthLevel() {
            return this.authLevel;
        }

        public QueryDocAllRolesResponseBodyAllRolesRoleSubRoles setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public QueryDocAllRolesResponseBodyAllRolesRoleSubRoles setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public QueryDocAllRolesResponseBodyAllRolesRoleSubRoles setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryDocAllRolesResponseBodyAllRolesRoleSubRoles setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

    public static class QueryDocAllRolesResponseBodyAllRolesRole extends TeaModel {
        @NameInMap("flowType")
        public String flowType;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        @NameInMap("roleType")
        public String roleType;

        @NameInMap("subRoles")
        public java.util.List<QueryDocAllRolesResponseBodyAllRolesRoleSubRoles> subRoles;

        public static QueryDocAllRolesResponseBodyAllRolesRole build(java.util.Map<String, ?> map) throws Exception {
            QueryDocAllRolesResponseBodyAllRolesRole self = new QueryDocAllRolesResponseBodyAllRolesRole();
            return TeaModel.build(map, self);
        }

        public QueryDocAllRolesResponseBodyAllRolesRole setFlowType(String flowType) {
            this.flowType = flowType;
            return this;
        }
        public String getFlowType() {
            return this.flowType;
        }

        public QueryDocAllRolesResponseBodyAllRolesRole setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryDocAllRolesResponseBodyAllRolesRole setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryDocAllRolesResponseBodyAllRolesRole setRoleType(String roleType) {
            this.roleType = roleType;
            return this;
        }
        public String getRoleType() {
            return this.roleType;
        }

        public QueryDocAllRolesResponseBodyAllRolesRole setSubRoles(java.util.List<QueryDocAllRolesResponseBodyAllRolesRoleSubRoles> subRoles) {
            this.subRoles = subRoles;
            return this;
        }
        public java.util.List<QueryDocAllRolesResponseBodyAllRolesRoleSubRoles> getSubRoles() {
            return this.subRoles;
        }

    }

    public static class QueryDocAllRolesResponseBodyAllRoles extends TeaModel {
        @NameInMap("members")
        public java.util.List<QueryDocAllRolesResponseBodyAllRolesMembers> members;

        @NameInMap("role")
        public QueryDocAllRolesResponseBodyAllRolesRole role;

        public static QueryDocAllRolesResponseBodyAllRoles build(java.util.Map<String, ?> map) throws Exception {
            QueryDocAllRolesResponseBodyAllRoles self = new QueryDocAllRolesResponseBodyAllRoles();
            return TeaModel.build(map, self);
        }

        public QueryDocAllRolesResponseBodyAllRoles setMembers(java.util.List<QueryDocAllRolesResponseBodyAllRolesMembers> members) {
            this.members = members;
            return this;
        }
        public java.util.List<QueryDocAllRolesResponseBodyAllRolesMembers> getMembers() {
            return this.members;
        }

        public QueryDocAllRolesResponseBodyAllRoles setRole(QueryDocAllRolesResponseBodyAllRolesRole role) {
            this.role = role;
            return this;
        }
        public QueryDocAllRolesResponseBodyAllRolesRole getRole() {
            return this.role;
        }

    }

    public static class QueryDocAllRolesResponseBodyDefaultRole extends TeaModel {
        @NameInMap("mode")
        public Integer mode;

        @NameInMap("roleId")
        public Long roleId;

        public static QueryDocAllRolesResponseBodyDefaultRole build(java.util.Map<String, ?> map) throws Exception {
            QueryDocAllRolesResponseBodyDefaultRole self = new QueryDocAllRolesResponseBodyDefaultRole();
            return TeaModel.build(map, self);
        }

        public QueryDocAllRolesResponseBodyDefaultRole setMode(Integer mode) {
            this.mode = mode;
            return this;
        }
        public Integer getMode() {
            return this.mode;
        }

        public QueryDocAllRolesResponseBodyDefaultRole setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

    }

}
