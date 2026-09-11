// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ListReviewChecklistsResponseBody extends TeaModel {
    @NameInMap("data")
    public ListReviewChecklistsResponseBodyData data;

    public static ListReviewChecklistsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListReviewChecklistsResponseBody self = new ListReviewChecklistsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListReviewChecklistsResponseBody setData(ListReviewChecklistsResponseBodyData data) {
        this.data = data;
        return this;
    }
    public ListReviewChecklistsResponseBodyData getData() {
        return this.data;
    }

    public static class ListReviewChecklistsResponseBodyDataChecklistsRulesItems extends TeaModel {
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

        public static ListReviewChecklistsResponseBodyDataChecklistsRulesItems build(java.util.Map<String, ?> map) throws Exception {
            ListReviewChecklistsResponseBodyDataChecklistsRulesItems self = new ListReviewChecklistsResponseBodyDataChecklistsRulesItems();
            return TeaModel.build(map, self);
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class ListReviewChecklistsResponseBodyDataChecklistsRules extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<ListReviewChecklistsResponseBodyDataChecklistsRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static ListReviewChecklistsResponseBodyDataChecklistsRules build(java.util.Map<String, ?> map) throws Exception {
            ListReviewChecklistsResponseBodyDataChecklistsRules self = new ListReviewChecklistsResponseBodyDataChecklistsRules();
            return TeaModel.build(map, self);
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setItems(java.util.List<ListReviewChecklistsResponseBodyDataChecklistsRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<ListReviewChecklistsResponseBodyDataChecklistsRulesItems> getItems() {
            return this.items;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public ListReviewChecklistsResponseBodyDataChecklistsRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class ListReviewChecklistsResponseBodyDataChecklists extends TeaModel {
        @NameInMap("created_at")
        public String createdAt;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("rules")
        public java.util.List<ListReviewChecklistsResponseBodyDataChecklistsRules> rules;

        @NameInMap("updated_at")
        public String updatedAt;

        @NameInMap("version")
        public Long version;

        public static ListReviewChecklistsResponseBodyDataChecklists build(java.util.Map<String, ?> map) throws Exception {
            ListReviewChecklistsResponseBodyDataChecklists self = new ListReviewChecklistsResponseBodyDataChecklists();
            return TeaModel.build(map, self);
        }

        public ListReviewChecklistsResponseBodyDataChecklists setCreatedAt(String createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public String getCreatedAt() {
            return this.createdAt;
        }

        public ListReviewChecklistsResponseBodyDataChecklists setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListReviewChecklistsResponseBodyDataChecklists setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListReviewChecklistsResponseBodyDataChecklists setRules(java.util.List<ListReviewChecklistsResponseBodyDataChecklistsRules> rules) {
            this.rules = rules;
            return this;
        }
        public java.util.List<ListReviewChecklistsResponseBodyDataChecklistsRules> getRules() {
            return this.rules;
        }

        public ListReviewChecklistsResponseBodyDataChecklists setUpdatedAt(String updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }
        public String getUpdatedAt() {
            return this.updatedAt;
        }

        public ListReviewChecklistsResponseBodyDataChecklists setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

    public static class ListReviewChecklistsResponseBodyData extends TeaModel {
        @NameInMap("checklists")
        public java.util.List<ListReviewChecklistsResponseBodyDataChecklists> checklists;

        @NameInMap("corp_id")
        public String corpId;

        public static ListReviewChecklistsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListReviewChecklistsResponseBodyData self = new ListReviewChecklistsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListReviewChecklistsResponseBodyData setChecklists(java.util.List<ListReviewChecklistsResponseBodyDataChecklists> checklists) {
            this.checklists = checklists;
            return this;
        }
        public java.util.List<ListReviewChecklistsResponseBodyDataChecklists> getChecklists() {
            return this.checklists;
        }

        public ListReviewChecklistsResponseBodyData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

}
