// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateReviewChecklistRequest extends TeaModel {
    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("name")
    public String name;

    @NameInMap("rules")
    public java.util.List<CreateReviewChecklistRequestRules> rules;

    public static CreateReviewChecklistRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateReviewChecklistRequest self = new CreateReviewChecklistRequest();
        return TeaModel.build(map, self);
    }

    public CreateReviewChecklistRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateReviewChecklistRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateReviewChecklistRequest setRules(java.util.List<CreateReviewChecklistRequestRules> rules) {
        this.rules = rules;
        return this;
    }
    public java.util.List<CreateReviewChecklistRequestRules> getRules() {
        return this.rules;
    }

    public static class CreateReviewChecklistRequestRulesItems extends TeaModel {
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

        public static CreateReviewChecklistRequestRulesItems build(java.util.Map<String, ?> map) throws Exception {
            CreateReviewChecklistRequestRulesItems self = new CreateReviewChecklistRequestRulesItems();
            return TeaModel.build(map, self);
        }

        public CreateReviewChecklistRequestRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public CreateReviewChecklistRequestRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public CreateReviewChecklistRequestRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateReviewChecklistRequestRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateReviewChecklistRequestRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class CreateReviewChecklistRequestRules extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<CreateReviewChecklistRequestRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static CreateReviewChecklistRequestRules build(java.util.Map<String, ?> map) throws Exception {
            CreateReviewChecklistRequestRules self = new CreateReviewChecklistRequestRules();
            return TeaModel.build(map, self);
        }

        public CreateReviewChecklistRequestRules setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public CreateReviewChecklistRequestRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateReviewChecklistRequestRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateReviewChecklistRequestRules setItems(java.util.List<CreateReviewChecklistRequestRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<CreateReviewChecklistRequestRulesItems> getItems() {
            return this.items;
        }

        public CreateReviewChecklistRequestRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateReviewChecklistRequestRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public CreateReviewChecklistRequestRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

}
