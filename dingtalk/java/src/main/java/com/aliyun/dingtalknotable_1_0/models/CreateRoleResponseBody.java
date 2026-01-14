// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CreateRoleResponseBody extends TeaModel {
    @NameInMap("flowType")
    public String flowType;

    @NameInMap("id")
    public Long id;

    @NameInMap("name")
    public String name;

    @NameInMap("roleType")
    public String roleType;

    @NameInMap("subRoles")
    public java.util.List<CreateRoleResponseBodySubRoles> subRoles;

    public static CreateRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRoleResponseBody self = new CreateRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRoleResponseBody setFlowType(String flowType) {
        this.flowType = flowType;
        return this;
    }
    public String getFlowType() {
        return this.flowType;
    }

    public CreateRoleResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public CreateRoleResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateRoleResponseBody setRoleType(String roleType) {
        this.roleType = roleType;
        return this;
    }
    public String getRoleType() {
        return this.roleType;
    }

    public CreateRoleResponseBody setSubRoles(java.util.List<CreateRoleResponseBodySubRoles> subRoles) {
        this.subRoles = subRoles;
        return this;
    }
    public java.util.List<CreateRoleResponseBodySubRoles> getSubRoles() {
        return this.subRoles;
    }

    public static class CreateRoleResponseBodySubRoles extends TeaModel {
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

        public static CreateRoleResponseBodySubRoles build(java.util.Map<String, ?> map) throws Exception {
            CreateRoleResponseBodySubRoles self = new CreateRoleResponseBodySubRoles();
            return TeaModel.build(map, self);
        }

        public CreateRoleResponseBodySubRoles setAuthLevel(Integer authLevel) {
            this.authLevel = authLevel;
            return this;
        }
        public Integer getAuthLevel() {
            return this.authLevel;
        }

        public CreateRoleResponseBodySubRoles setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public CreateRoleResponseBodySubRoles setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public CreateRoleResponseBodySubRoles setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public CreateRoleResponseBodySubRoles setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
