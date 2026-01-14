// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UpdateRoleResponseBody extends TeaModel {
    @NameInMap("flowType")
    public String flowType;

    @NameInMap("id")
    public Long id;

    @NameInMap("name")
    public String name;

    @NameInMap("roleType")
    public String roleType;

    @NameInMap("subRoles")
    public java.util.List<UpdateRoleResponseBodySubRoles> subRoles;

    public static UpdateRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRoleResponseBody self = new UpdateRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRoleResponseBody setFlowType(String flowType) {
        this.flowType = flowType;
        return this;
    }
    public String getFlowType() {
        return this.flowType;
    }

    public UpdateRoleResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateRoleResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateRoleResponseBody setRoleType(String roleType) {
        this.roleType = roleType;
        return this;
    }
    public String getRoleType() {
        return this.roleType;
    }

    public UpdateRoleResponseBody setSubRoles(java.util.List<UpdateRoleResponseBodySubRoles> subRoles) {
        this.subRoles = subRoles;
        return this;
    }
    public java.util.List<UpdateRoleResponseBodySubRoles> getSubRoles() {
        return this.subRoles;
    }

    public static class UpdateRoleResponseBodySubRoles extends TeaModel {
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

        public static UpdateRoleResponseBodySubRoles build(java.util.Map<String, ?> map) throws Exception {
            UpdateRoleResponseBodySubRoles self = new UpdateRoleResponseBodySubRoles();
            return TeaModel.build(map, self);
        }

        public UpdateRoleResponseBodySubRoles setAuthLevel(Integer authLevel) {
            this.authLevel = authLevel;
            return this;
        }
        public Integer getAuthLevel() {
            return this.authLevel;
        }

        public UpdateRoleResponseBodySubRoles setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public UpdateRoleResponseBodySubRoles setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public UpdateRoleResponseBodySubRoles setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public UpdateRoleResponseBodySubRoles setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
