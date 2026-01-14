// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CreateRoleRequest extends TeaModel {
    @NameInMap("flowType")
    public String flowType;

    @NameInMap("id")
    public Long id;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleType")
    public String roleType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subRoles")
    public java.util.List<CreateRoleRequestSubRoles> subRoles;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRoleRequest self = new CreateRoleRequest();
        return TeaModel.build(map, self);
    }

    public CreateRoleRequest setFlowType(String flowType) {
        this.flowType = flowType;
        return this;
    }
    public String getFlowType() {
        return this.flowType;
    }

    public CreateRoleRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public CreateRoleRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateRoleRequest setRoleType(String roleType) {
        this.roleType = roleType;
        return this;
    }
    public String getRoleType() {
        return this.roleType;
    }

    public CreateRoleRequest setSubRoles(java.util.List<CreateRoleRequestSubRoles> subRoles) {
        this.subRoles = subRoles;
        return this;
    }
    public java.util.List<CreateRoleRequestSubRoles> getSubRoles() {
        return this.subRoles;
    }

    public CreateRoleRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateRoleRequestSubRoles extends TeaModel {
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

        public static CreateRoleRequestSubRoles build(java.util.Map<String, ?> map) throws Exception {
            CreateRoleRequestSubRoles self = new CreateRoleRequestSubRoles();
            return TeaModel.build(map, self);
        }

        public CreateRoleRequestSubRoles setAuthLevel(Integer authLevel) {
            this.authLevel = authLevel;
            return this;
        }
        public Integer getAuthLevel() {
            return this.authLevel;
        }

        public CreateRoleRequestSubRoles setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public CreateRoleRequestSubRoles setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public CreateRoleRequestSubRoles setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public CreateRoleRequestSubRoles setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
