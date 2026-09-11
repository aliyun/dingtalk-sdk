// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateReviewChecklistRequest extends TeaModel {
    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("name")
    public String name;

    @NameInMap("rules")
    public java.util.List<UpdateReviewChecklistRequestRules> rules;

    public static UpdateReviewChecklistRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateReviewChecklistRequest self = new UpdateReviewChecklistRequest();
        return TeaModel.build(map, self);
    }

    public UpdateReviewChecklistRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateReviewChecklistRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateReviewChecklistRequest setRules(java.util.List<UpdateReviewChecklistRequestRules> rules) {
        this.rules = rules;
        return this;
    }
    public java.util.List<UpdateReviewChecklistRequestRules> getRules() {
        return this.rules;
    }

    public static class UpdateReviewChecklistRequestRulesItems extends TeaModel {
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

        public static UpdateReviewChecklistRequestRulesItems build(java.util.Map<String, ?> map) throws Exception {
            UpdateReviewChecklistRequestRulesItems self = new UpdateReviewChecklistRequestRulesItems();
            return TeaModel.build(map, self);
        }

        public UpdateReviewChecklistRequestRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public UpdateReviewChecklistRequestRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public UpdateReviewChecklistRequestRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateReviewChecklistRequestRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateReviewChecklistRequestRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class UpdateReviewChecklistRequestRules extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<UpdateReviewChecklistRequestRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static UpdateReviewChecklistRequestRules build(java.util.Map<String, ?> map) throws Exception {
            UpdateReviewChecklistRequestRules self = new UpdateReviewChecklistRequestRules();
            return TeaModel.build(map, self);
        }

        public UpdateReviewChecklistRequestRules setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public UpdateReviewChecklistRequestRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UpdateReviewChecklistRequestRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateReviewChecklistRequestRules setItems(java.util.List<UpdateReviewChecklistRequestRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<UpdateReviewChecklistRequestRulesItems> getItems() {
            return this.items;
        }

        public UpdateReviewChecklistRequestRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateReviewChecklistRequestRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public UpdateReviewChecklistRequestRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

}
