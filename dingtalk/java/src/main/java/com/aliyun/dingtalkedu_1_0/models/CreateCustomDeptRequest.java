// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomDeptRequest extends TeaModel {
    @NameInMap("customDept")
    public CreateCustomDeptRequestCustomDept customDept;

    // 上级部门ID（type为custom_campus时，必须为-7）
    @NameInMap("superId")
    public Long superId;

    // 钉钉管理员员工ID
    @NameInMap("operator")
    public String operator;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static CreateCustomDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomDeptRequest self = new CreateCustomDeptRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomDeptRequest setCustomDept(CreateCustomDeptRequestCustomDept customDept) {
        this.customDept = customDept;
        return this;
    }
    public CreateCustomDeptRequestCustomDept getCustomDept() {
        return this.customDept;
    }

    public CreateCustomDeptRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

    public CreateCustomDeptRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public CreateCustomDeptRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreateCustomDeptRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateCustomDeptRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateCustomDeptRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public CreateCustomDeptRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateCustomDeptRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public static class CreateCustomDeptRequestCustomDept extends TeaModel {
        // 部门类型：custom_campus: 自定义校区；custom_dept: 自定义部门
        @NameInMap("type")
        public String type;

        // 自定义校区或部门名称
        @NameInMap("name")
        public String name;

        public static CreateCustomDeptRequestCustomDept build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomDeptRequestCustomDept self = new CreateCustomDeptRequestCustomDept();
            return TeaModel.build(map, self);
        }

        public CreateCustomDeptRequestCustomDept setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateCustomDeptRequestCustomDept setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
