// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomClassRequest extends TeaModel {
    // 班级信息
    @NameInMap("customClass")
    public CreateCustomClassRequestCustomClass customClass;

    // 上级部门ID
    @NameInMap("superId")
    public Long superId;

    // 钉钉企业管理员工ID
    @NameInMap("operator")
    public String operator;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    public static CreateCustomClassRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomClassRequest self = new CreateCustomClassRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomClassRequest setCustomClass(CreateCustomClassRequestCustomClass customClass) {
        this.customClass = customClass;
        return this;
    }
    public CreateCustomClassRequestCustomClass getCustomClass() {
        return this.customClass;
    }

    public CreateCustomClassRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

    public CreateCustomClassRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public CreateCustomClassRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateCustomClassRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateCustomClassRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public CreateCustomClassRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateCustomClassRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateCustomClassRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public static class CreateCustomClassRequestCustomClass extends TeaModel {
        // 班级名称
        @NameInMap("name")
        public String name;

        public static CreateCustomClassRequestCustomClass build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomClassRequestCustomClass self = new CreateCustomClassRequestCustomClass();
            return TeaModel.build(map, self);
        }

        public CreateCustomClassRequestCustomClass setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
