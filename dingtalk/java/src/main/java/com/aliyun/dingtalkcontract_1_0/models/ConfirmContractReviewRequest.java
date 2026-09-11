// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ConfirmContractReviewRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("checklist_id")
    public String checklistId;

    @NameInMap("contract_type")
    public String contractType;

    @NameInMap("custom_rules")
    public java.util.List<ConfirmContractReviewRequestCustomRules> customRules;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("review_id")
    public String reviewId;

    @NameInMap("scale")
    public String scale;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("session_id")
    public String sessionId;

    @NameInMap("standpoint")
    public String standpoint;

    public static ConfirmContractReviewRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmContractReviewRequest self = new ConfirmContractReviewRequest();
        return TeaModel.build(map, self);
    }

    public ConfirmContractReviewRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public ConfirmContractReviewRequest setChecklistId(String checklistId) {
        this.checklistId = checklistId;
        return this;
    }
    public String getChecklistId() {
        return this.checklistId;
    }

    public ConfirmContractReviewRequest setContractType(String contractType) {
        this.contractType = contractType;
        return this;
    }
    public String getContractType() {
        return this.contractType;
    }

    public ConfirmContractReviewRequest setCustomRules(java.util.List<ConfirmContractReviewRequestCustomRules> customRules) {
        this.customRules = customRules;
        return this;
    }
    public java.util.List<ConfirmContractReviewRequestCustomRules> getCustomRules() {
        return this.customRules;
    }

    public ConfirmContractReviewRequest setReviewId(String reviewId) {
        this.reviewId = reviewId;
        return this;
    }
    public String getReviewId() {
        return this.reviewId;
    }

    public ConfirmContractReviewRequest setScale(String scale) {
        this.scale = scale;
        return this;
    }
    public String getScale() {
        return this.scale;
    }

    public ConfirmContractReviewRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

    public ConfirmContractReviewRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

    public static class ConfirmContractReviewRequestCustomRulesItems extends TeaModel {
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

        public static ConfirmContractReviewRequestCustomRulesItems build(java.util.Map<String, ?> map) throws Exception {
            ConfirmContractReviewRequestCustomRulesItems self = new ConfirmContractReviewRequestCustomRulesItems();
            return TeaModel.build(map, self);
        }

        public ConfirmContractReviewRequestCustomRulesItems setCriteria(String criteria) {
            this.criteria = criteria;
            return this;
        }
        public String getCriteria() {
            return this.criteria;
        }

        public ConfirmContractReviewRequestCustomRulesItems setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public ConfirmContractReviewRequestCustomRulesItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ConfirmContractReviewRequestCustomRulesItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ConfirmContractReviewRequestCustomRulesItems setSeverity(String severity) {
            this.severity = severity;
            return this;
        }
        public String getSeverity() {
            return this.severity;
        }

    }

    public static class ConfirmContractReviewRequestCustomRules extends TeaModel {
        @NameInMap("contract_type")
        public String contractType;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("items")
        public java.util.List<ConfirmContractReviewRequestCustomRulesItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("risk_level")
        public String riskLevel;

        @NameInMap("standpoint")
        public String standpoint;

        public static ConfirmContractReviewRequestCustomRules build(java.util.Map<String, ?> map) throws Exception {
            ConfirmContractReviewRequestCustomRules self = new ConfirmContractReviewRequestCustomRules();
            return TeaModel.build(map, self);
        }

        public ConfirmContractReviewRequestCustomRules setContractType(String contractType) {
            this.contractType = contractType;
            return this;
        }
        public String getContractType() {
            return this.contractType;
        }

        public ConfirmContractReviewRequestCustomRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ConfirmContractReviewRequestCustomRules setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ConfirmContractReviewRequestCustomRules setItems(java.util.List<ConfirmContractReviewRequestCustomRulesItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<ConfirmContractReviewRequestCustomRulesItems> getItems() {
            return this.items;
        }

        public ConfirmContractReviewRequestCustomRules setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ConfirmContractReviewRequestCustomRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public ConfirmContractReviewRequestCustomRules setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

}
