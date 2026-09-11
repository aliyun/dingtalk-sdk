// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateChecklistRuleResponseBody extends TeaModel {
    @NameInMap("data")
    public UpdateChecklistRuleResponseBodyData data;

    public static UpdateChecklistRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateChecklistRuleResponseBody self = new UpdateChecklistRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateChecklistRuleResponseBody setData(UpdateChecklistRuleResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UpdateChecklistRuleResponseBodyData getData() {
        return this.data;
    }

    public static class UpdateChecklistRuleResponseBodyDataRuleItems extends TeaModel {
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

        public static UpdateChecklistRuleResponseBodyDataRuleItems build(java.util.Map<String, ?> map) throws Exception {
            UpdateChecklistRuleResponseBodyDataRuleItems self = new UpdateChecklistRuleResponseBodyDataRuleItems();
            return TeaModel.build(map, self);
        }

        public UpdateChecklistRuleResponseBodyDataRuleItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public UpdateChecklistRuleResponseBodyDataRuleItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public UpdateChecklistRuleResponseBodyDataRuleItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateChecklistRuleResponseBodyDataRuleItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateChecklistRuleResponseBodyDataRuleItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class UpdateChecklistRuleResponseBodyDataRule extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<UpdateChecklistRuleResponseBodyDataRuleItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static UpdateChecklistRuleResponseBodyDataRule build(java.util.Map<String, ?> map) throws Exception {
            UpdateChecklistRuleResponseBodyDataRule self = new UpdateChecklistRuleResponseBodyDataRule();
            return TeaModel.build(map, self);
        }

        public UpdateChecklistRuleResponseBodyDataRule setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public UpdateChecklistRuleResponseBodyDataRule setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UpdateChecklistRuleResponseBodyDataRule setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateChecklistRuleResponseBodyDataRule setItems(java.util.List<UpdateChecklistRuleResponseBodyDataRuleItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<UpdateChecklistRuleResponseBodyDataRuleItems> getItems() {
            return this.items;
        }

        public UpdateChecklistRuleResponseBodyDataRule setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateChecklistRuleResponseBodyDataRule setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public UpdateChecklistRuleResponseBodyDataRule setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class UpdateChecklistRuleResponseBodyData extends TeaModel {
        @NameInMap("rule")
        public UpdateChecklistRuleResponseBodyDataRule rule;

        public static UpdateChecklistRuleResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UpdateChecklistRuleResponseBodyData self = new UpdateChecklistRuleResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UpdateChecklistRuleResponseBodyData setRule(UpdateChecklistRuleResponseBodyDataRule rule) {
            this.rule = rule;
            return this;
        }
        public UpdateChecklistRuleResponseBodyDataRule getRule() {
            return this.rule;
        }

    }

}
