// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateReviewChecklistResponseBody extends TeaModel {
    @NameInMap("data")
    public UpdateReviewChecklistResponseBodyData data;

    public static UpdateReviewChecklistResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateReviewChecklistResponseBody self = new UpdateReviewChecklistResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateReviewChecklistResponseBody setData(UpdateReviewChecklistResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UpdateReviewChecklistResponseBodyData getData() {
        return this.data;
    }

    public static class UpdateReviewChecklistResponseBodyDataChecklistRulesItems extends TeaModel {
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

        public static UpdateReviewChecklistResponseBodyDataChecklistRulesItems build(java.util.Map<String, ?> map) throws Exception {
            UpdateReviewChecklistResponseBodyDataChecklistRulesItems self = new UpdateReviewChecklistResponseBodyDataChecklistRulesItems();
            return TeaModel.build(map, self);
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class UpdateReviewChecklistResponseBodyDataChecklistRules extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<UpdateReviewChecklistResponseBodyDataChecklistRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static UpdateReviewChecklistResponseBodyDataChecklistRules build(java.util.Map<String, ?> map) throws Exception {
            UpdateReviewChecklistResponseBodyDataChecklistRules self = new UpdateReviewChecklistResponseBodyDataChecklistRules();
            return TeaModel.build(map, self);
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setItems(java.util.List<UpdateReviewChecklistResponseBodyDataChecklistRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<UpdateReviewChecklistResponseBodyDataChecklistRulesItems> getItems() {
            return this.items;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public UpdateReviewChecklistResponseBodyDataChecklistRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class UpdateReviewChecklistResponseBodyDataChecklist extends TeaModel {
        @NameInMap("created_at")
        public String createdAt;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("rules")
        public java.util.List<UpdateReviewChecklistResponseBodyDataChecklistRules> rules;

        @NameInMap("updated_at")
        public String updatedAt;

        @NameInMap("version")
        public Long version;

        public static UpdateReviewChecklistResponseBodyDataChecklist build(java.util.Map<String, ?> map) throws Exception {
            UpdateReviewChecklistResponseBodyDataChecklist self = new UpdateReviewChecklistResponseBodyDataChecklist();
            return TeaModel.build(map, self);
        }

        public UpdateReviewChecklistResponseBodyDataChecklist setCreatedAt(String createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public String getCreatedAt() {
            return this.createdAt;
        }

        public UpdateReviewChecklistResponseBodyDataChecklist setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateReviewChecklistResponseBodyDataChecklist setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateReviewChecklistResponseBodyDataChecklist setRules(java.util.List<UpdateReviewChecklistResponseBodyDataChecklistRules> rules) {
            this.rules = rules;
            return this;
        }
        public java.util.List<UpdateReviewChecklistResponseBodyDataChecklistRules> getRules() {
            return this.rules;
        }

        public UpdateReviewChecklistResponseBodyDataChecklist setUpdatedAt(String updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }
        public String getUpdatedAt() {
            return this.updatedAt;
        }

        public UpdateReviewChecklistResponseBodyDataChecklist setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

    public static class UpdateReviewChecklistResponseBodyData extends TeaModel {
        @NameInMap("checklist")
        public UpdateReviewChecklistResponseBodyDataChecklist checklist;

        public static UpdateReviewChecklistResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UpdateReviewChecklistResponseBodyData self = new UpdateReviewChecklistResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UpdateReviewChecklistResponseBodyData setChecklist(UpdateReviewChecklistResponseBodyDataChecklist checklist) {
            this.checklist = checklist;
            return this;
        }
        public UpdateReviewChecklistResponseBodyDataChecklist getChecklist() {
            return this.checklist;
        }

    }

}
