// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetUserDocRolesResponseBody extends TeaModel {
    @NameInMap("enabled")
    public Boolean enabled;

    @NameInMap("roles")
    public java.util.List<GetUserDocRolesResponseBodyRoles> roles;

    public static GetUserDocRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserDocRolesResponseBody self = new GetUserDocRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserDocRolesResponseBody setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

    public GetUserDocRolesResponseBody setRoles(java.util.List<GetUserDocRolesResponseBodyRoles> roles) {
        this.roles = roles;
        return this;
    }
    public java.util.List<GetUserDocRolesResponseBodyRoles> getRoles() {
        return this.roles;
    }

    public static class GetUserDocRolesResponseBodyRolesSubRoles extends TeaModel {
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

        public static GetUserDocRolesResponseBodyRolesSubRoles build(java.util.Map<String, ?> map) throws Exception {
            GetUserDocRolesResponseBodyRolesSubRoles self = new GetUserDocRolesResponseBodyRolesSubRoles();
            return TeaModel.build(map, self);
        }

        public GetUserDocRolesResponseBodyRolesSubRoles setAuthLevel(Integer authLevel) {
            this.authLevel = authLevel;
            return this;
        }
        public Integer getAuthLevel() {
            return this.authLevel;
        }

        public GetUserDocRolesResponseBodyRolesSubRoles setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public GetUserDocRolesResponseBodyRolesSubRoles setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public GetUserDocRolesResponseBodyRolesSubRoles setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public GetUserDocRolesResponseBodyRolesSubRoles setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

    public static class GetUserDocRolesResponseBodyRoles extends TeaModel {
        @NameInMap("flowType")
        public String flowType;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        @NameInMap("roleType")
        public String roleType;

        @NameInMap("subRoles")
        public java.util.List<GetUserDocRolesResponseBodyRolesSubRoles> subRoles;

        public static GetUserDocRolesResponseBodyRoles build(java.util.Map<String, ?> map) throws Exception {
            GetUserDocRolesResponseBodyRoles self = new GetUserDocRolesResponseBodyRoles();
            return TeaModel.build(map, self);
        }

        public GetUserDocRolesResponseBodyRoles setFlowType(String flowType) {
            this.flowType = flowType;
            return this;
        }
        public String getFlowType() {
            return this.flowType;
        }

        public GetUserDocRolesResponseBodyRoles setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetUserDocRolesResponseBodyRoles setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetUserDocRolesResponseBodyRoles setRoleType(String roleType) {
            this.roleType = roleType;
            return this;
        }
        public String getRoleType() {
            return this.roleType;
        }

        public GetUserDocRolesResponseBodyRoles setSubRoles(java.util.List<GetUserDocRolesResponseBodyRolesSubRoles> subRoles) {
            this.subRoles = subRoles;
            return this;
        }
        public java.util.List<GetUserDocRolesResponseBodyRolesSubRoles> getSubRoles() {
            return this.subRoles;
        }

    }

}
