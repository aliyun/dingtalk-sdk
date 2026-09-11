// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateChecklistRuleRequest extends TeaModel {
    @NameInMap("contract_type")
    public String contractType;

    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("description")
    public String description;

    @NameInMap("items")
    public java.util.List<CreateChecklistRuleRequestItems> items;

    @NameInMap("name")
    public String name;

    @NameInMap("risk_level")
    public String riskLevel;

    @NameInMap("standpoint")
    public String standpoint;

    public static CreateChecklistRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateChecklistRuleRequest self = new CreateChecklistRuleRequest();
        return TeaModel.build(map, self);
    }

    public CreateChecklistRuleRequest setContractType(String contractType) {
        this.contractType = contractType;
        return this;
    }
    public String getContractType() {
        return this.contractType;
    }

    public CreateChecklistRuleRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateChecklistRuleRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateChecklistRuleRequest setItems(java.util.List<CreateChecklistRuleRequestItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<CreateChecklistRuleRequestItems> getItems() {
        return this.items;
    }

    public CreateChecklistRuleRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateChecklistRuleRequest setRiskLevel(String riskLevel) {
        this.riskLevel = riskLevel;
        return this;
    }
    public String getRiskLevel() {
        return this.riskLevel;
    }

    public CreateChecklistRuleRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

    public static class CreateChecklistRuleRequestItems extends TeaModel {
        @NameInMap("criteria")
        public String criteria;

        @NameInMap("enabled")
        public Boolean enabled;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("severity")
        public String severity;

        public static CreateChecklistRuleRequestItems build(java.util.Map<String, ?> map) throws Exception {
            CreateChecklistRuleRequestItems self = new CreateChecklistRuleRequestItems();
            return TeaModel.build(map, self);
        }

        public CreateChecklistRuleRequestItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public CreateChecklistRuleRequestItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public CreateChecklistRuleRequestItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateChecklistRuleRequestItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateChecklistRuleRequestItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

}
