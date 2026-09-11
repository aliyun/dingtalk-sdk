// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateReviewChecklistResponseBody extends TeaModel {
    @NameInMap("data")
    public CreateReviewChecklistResponseBodyData data;

    public static CreateReviewChecklistResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateReviewChecklistResponseBody self = new CreateReviewChecklistResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateReviewChecklistResponseBody setData(CreateReviewChecklistResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateReviewChecklistResponseBodyData getData() {
        return this.data;
    }

    public static class CreateReviewChecklistResponseBodyDataChecklistRulesItems extends TeaModel {
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

        public static CreateReviewChecklistResponseBodyDataChecklistRulesItems build(java.util.Map<String, ?> map) throws Exception {
            CreateReviewChecklistResponseBodyDataChecklistRulesItems self = new CreateReviewChecklistResponseBodyDataChecklistRulesItems();
            return TeaModel.build(map, self);
        }

        public CreateReviewChecklistResponseBodyDataChecklistRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class CreateReviewChecklistResponseBodyDataChecklistRules extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<CreateReviewChecklistResponseBodyDataChecklistRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static CreateReviewChecklistResponseBodyDataChecklistRules build(java.util.Map<String, ?> map) throws Exception {
            CreateReviewChecklistResponseBodyDataChecklistRules self = new CreateReviewChecklistResponseBodyDataChecklistRules();
            return TeaModel.build(map, self);
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setItems(java.util.List<CreateReviewChecklistResponseBodyDataChecklistRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<CreateReviewChecklistResponseBodyDataChecklistRulesItems> getItems() {
            return this.items;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public CreateReviewChecklistResponseBodyDataChecklistRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class CreateReviewChecklistResponseBodyDataChecklist extends TeaModel {
        @NameInMap("created_at")
        public String createdAt;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("rules")
        public java.util.List<CreateReviewChecklistResponseBodyDataChecklistRules> rules;

        @NameInMap("updated_at")
        public String updatedAt;

        @NameInMap("version")
        public Long version;

        public static CreateReviewChecklistResponseBodyDataChecklist build(java.util.Map<String, ?> map) throws Exception {
            CreateReviewChecklistResponseBodyDataChecklist self = new CreateReviewChecklistResponseBodyDataChecklist();
            return TeaModel.build(map, self);
        }

        public CreateReviewChecklistResponseBodyDataChecklist setCreatedAt(String createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public String getCreatedAt() {
            return this.createdAt;
        }

        public CreateReviewChecklistResponseBodyDataChecklist setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateReviewChecklistResponseBodyDataChecklist setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateReviewChecklistResponseBodyDataChecklist setRules(java.util.List<CreateReviewChecklistResponseBodyDataChecklistRules> rules) {
            this.rules = rules;
            return this;
        }
        public java.util.List<CreateReviewChecklistResponseBodyDataChecklistRules> getRules() {
            return this.rules;
        }

        public CreateReviewChecklistResponseBodyDataChecklist setUpdatedAt(String updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }
        public String getUpdatedAt() {
            return this.updatedAt;
        }

        public CreateReviewChecklistResponseBodyDataChecklist setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

    public static class CreateReviewChecklistResponseBodyData extends TeaModel {
        @NameInMap("checklist")
        public CreateReviewChecklistResponseBodyDataChecklist checklist;

        public static CreateReviewChecklistResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateReviewChecklistResponseBodyData self = new CreateReviewChecklistResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateReviewChecklistResponseBodyData setChecklist(CreateReviewChecklistResponseBodyDataChecklist checklist) {
            this.checklist = checklist;
            return this;
        }
        public CreateReviewChecklistResponseBodyDataChecklist getChecklist() {
            return this.checklist;
        }

    }

}
