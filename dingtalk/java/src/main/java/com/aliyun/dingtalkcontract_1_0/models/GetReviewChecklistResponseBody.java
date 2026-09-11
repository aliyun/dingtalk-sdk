// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetReviewChecklistResponseBody extends TeaModel {
    @NameInMap("data")
    public GetReviewChecklistResponseBodyData data;

    public static GetReviewChecklistResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetReviewChecklistResponseBody self = new GetReviewChecklistResponseBody();
        return TeaModel.build(map, self);
    }

    public GetReviewChecklistResponseBody setData(GetReviewChecklistResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetReviewChecklistResponseBodyData getData() {
        return this.data;
    }

    public static class GetReviewChecklistResponseBodyDataChecklistRulesItems extends TeaModel {
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

        public static GetReviewChecklistResponseBodyDataChecklistRulesItems build(java.util.Map<String, ?> map) throws Exception {
            GetReviewChecklistResponseBodyDataChecklistRulesItems self = new GetReviewChecklistResponseBodyDataChecklistRulesItems();
            return TeaModel.build(map, self);
        }

        public GetReviewChecklistResponseBodyDataChecklistRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public GetReviewChecklistResponseBodyDataChecklistRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public GetReviewChecklistResponseBodyDataChecklistRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetReviewChecklistResponseBodyDataChecklistRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetReviewChecklistResponseBodyDataChecklistRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class GetReviewChecklistResponseBodyDataChecklistRules extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<GetReviewChecklistResponseBodyDataChecklistRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static GetReviewChecklistResponseBodyDataChecklistRules build(java.util.Map<String, ?> map) throws Exception {
            GetReviewChecklistResponseBodyDataChecklistRules self = new GetReviewChecklistResponseBodyDataChecklistRules();
            return TeaModel.build(map, self);
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setItems(java.util.List<GetReviewChecklistResponseBodyDataChecklistRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<GetReviewChecklistResponseBodyDataChecklistRulesItems> getItems() {
            return this.items;
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public GetReviewChecklistResponseBodyDataChecklistRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class GetReviewChecklistResponseBodyDataChecklist extends TeaModel {
        @NameInMap("created_at")
        public String createdAt;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("rules")
        public java.util.List<GetReviewChecklistResponseBodyDataChecklistRules> rules;

        @NameInMap("updated_at")
        public String updatedAt;

        @NameInMap("version")
        public Long version;

        public static GetReviewChecklistResponseBodyDataChecklist build(java.util.Map<String, ?> map) throws Exception {
            GetReviewChecklistResponseBodyDataChecklist self = new GetReviewChecklistResponseBodyDataChecklist();
            return TeaModel.build(map, self);
        }

        public GetReviewChecklistResponseBodyDataChecklist setCreatedAt(String createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public String getCreatedAt() {
            return this.createdAt;
        }

        public GetReviewChecklistResponseBodyDataChecklist setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetReviewChecklistResponseBodyDataChecklist setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetReviewChecklistResponseBodyDataChecklist setRules(java.util.List<GetReviewChecklistResponseBodyDataChecklistRules> rules) {
            this.rules = rules;
            return this;
        }
        public java.util.List<GetReviewChecklistResponseBodyDataChecklistRules> getRules() {
            return this.rules;
        }

        public GetReviewChecklistResponseBodyDataChecklist setUpdatedAt(String updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }
        public String getUpdatedAt() {
            return this.updatedAt;
        }

        public GetReviewChecklistResponseBodyDataChecklist setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

    public static class GetReviewChecklistResponseBodyData extends TeaModel {
        @NameInMap("checklist")
        public GetReviewChecklistResponseBodyDataChecklist checklist;

        public static GetReviewChecklistResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetReviewChecklistResponseBodyData self = new GetReviewChecklistResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetReviewChecklistResponseBodyData setChecklist(GetReviewChecklistResponseBodyDataChecklist checklist) {
            this.checklist = checklist;
            return this;
        }
        public GetReviewChecklistResponseBodyDataChecklist getChecklist() {
            return this.checklist;
        }

    }

}
