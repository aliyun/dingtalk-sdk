// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateChecklistRuleResponseBody extends TeaModel {
    @NameInMap("data")
    public CreateChecklistRuleResponseBodyData data;

    public static CreateChecklistRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateChecklistRuleResponseBody self = new CreateChecklistRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateChecklistRuleResponseBody setData(CreateChecklistRuleResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateChecklistRuleResponseBodyData getData() {
        return this.data;
    }

    public static class CreateChecklistRuleResponseBodyDataRuleItems extends TeaModel {
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

        public static CreateChecklistRuleResponseBodyDataRuleItems build(java.util.Map<String, ?> map) throws Exception {
            CreateChecklistRuleResponseBodyDataRuleItems self = new CreateChecklistRuleResponseBodyDataRuleItems();
            return TeaModel.build(map, self);
        }

        public CreateChecklistRuleResponseBodyDataRuleItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public CreateChecklistRuleResponseBodyDataRuleItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public CreateChecklistRuleResponseBodyDataRuleItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateChecklistRuleResponseBodyDataRuleItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateChecklistRuleResponseBodyDataRuleItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class CreateChecklistRuleResponseBodyDataRule extends TeaModel {
        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<CreateChecklistRuleResponseBodyDataRuleItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static CreateChecklistRuleResponseBodyDataRule build(java.util.Map<String, ?> map) throws Exception {
            CreateChecklistRuleResponseBodyDataRule self = new CreateChecklistRuleResponseBodyDataRule();
            return TeaModel.build(map, self);
        }

        public CreateChecklistRuleResponseBodyDataRule setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public CreateChecklistRuleResponseBodyDataRule setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateChecklistRuleResponseBodyDataRule setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateChecklistRuleResponseBodyDataRule setItems(java.util.List<CreateChecklistRuleResponseBodyDataRuleItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<CreateChecklistRuleResponseBodyDataRuleItems> getItems() {
            return this.items;
        }

        public CreateChecklistRuleResponseBodyDataRule setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateChecklistRuleResponseBodyDataRule setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public CreateChecklistRuleResponseBodyDataRule setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class CreateChecklistRuleResponseBodyData extends TeaModel {
        @NameInMap("rule")
        public CreateChecklistRuleResponseBodyDataRule rule;

        public static CreateChecklistRuleResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateChecklistRuleResponseBodyData self = new CreateChecklistRuleResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateChecklistRuleResponseBodyData setRule(CreateChecklistRuleResponseBodyDataRule rule) {
            this.rule = rule;
            return this;
        }
        public CreateChecklistRuleResponseBodyDataRule getRule() {
            return this.rule;
        }

    }

}
