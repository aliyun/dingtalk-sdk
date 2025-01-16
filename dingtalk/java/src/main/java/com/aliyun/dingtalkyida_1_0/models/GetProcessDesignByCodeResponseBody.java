// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDesignByCodeResponseBody extends TeaModel {
    @NameInMap("approvalSummary")
    public java.util.List<GetProcessDesignByCodeResponseBodyApprovalSummary> approvalSummary;

    @NameInMap("flowConfig")
    public GetProcessDesignByCodeResponseBodyFlowConfig flowConfig;

    @NameInMap("formulaRules")
    public java.util.List<GetProcessDesignByCodeResponseBodyFormulaRules> formulaRules;

    @NameInMap("nodes")
    public java.util.List<GetProcessDesignByCodeResponseBodyNodes> nodes;

    @NameInMap("props")
    public GetProcessDesignByCodeResponseBodyProps props;

    public static GetProcessDesignByCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDesignByCodeResponseBody self = new GetProcessDesignByCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessDesignByCodeResponseBody setApprovalSummary(java.util.List<GetProcessDesignByCodeResponseBodyApprovalSummary> approvalSummary) {
        this.approvalSummary = approvalSummary;
        return this;
    }
    public java.util.List<GetProcessDesignByCodeResponseBodyApprovalSummary> getApprovalSummary() {
        return this.approvalSummary;
    }

    public GetProcessDesignByCodeResponseBody setFlowConfig(GetProcessDesignByCodeResponseBodyFlowConfig flowConfig) {
        this.flowConfig = flowConfig;
        return this;
    }
    public GetProcessDesignByCodeResponseBodyFlowConfig getFlowConfig() {
        return this.flowConfig;
    }

    public GetProcessDesignByCodeResponseBody setFormulaRules(java.util.List<GetProcessDesignByCodeResponseBodyFormulaRules> formulaRules) {
        this.formulaRules = formulaRules;
        return this;
    }
    public java.util.List<GetProcessDesignByCodeResponseBodyFormulaRules> getFormulaRules() {
        return this.formulaRules;
    }

    public GetProcessDesignByCodeResponseBody setNodes(java.util.List<GetProcessDesignByCodeResponseBodyNodes> nodes) {
        this.nodes = nodes;
        return this;
    }
    public java.util.List<GetProcessDesignByCodeResponseBodyNodes> getNodes() {
        return this.nodes;
    }

    public GetProcessDesignByCodeResponseBody setProps(GetProcessDesignByCodeResponseBodyProps props) {
        this.props = props;
        return this;
    }
    public GetProcessDesignByCodeResponseBodyProps getProps() {
        return this.props;
    }

    public static class GetProcessDesignByCodeResponseBodyApprovalSummaryTitle extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>zhangsan</p>
         */
        @NameInMap("en_US")
        public String enUS;

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("zh_CN")
        public String zhCN;

        public static GetProcessDesignByCodeResponseBodyApprovalSummaryTitle build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyApprovalSummaryTitle self = new GetProcessDesignByCodeResponseBodyApprovalSummaryTitle();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyApprovalSummaryTitle setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetProcessDesignByCodeResponseBodyApprovalSummaryTitle setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetProcessDesignByCodeResponseBodyApprovalSummaryTitle setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyApprovalSummary extends TeaModel {
        @NameInMap("title")
        public GetProcessDesignByCodeResponseBodyApprovalSummaryTitle title;

        public static GetProcessDesignByCodeResponseBodyApprovalSummary build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyApprovalSummary self = new GetProcessDesignByCodeResponseBodyApprovalSummary();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyApprovalSummary setTitle(GetProcessDesignByCodeResponseBodyApprovalSummaryTitle title) {
            this.title = title;
            return this;
        }
        public GetProcessDesignByCodeResponseBodyApprovalSummaryTitle getTitle() {
            return this.title;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>HIDDEN</p>
         */
        @NameInMap("fieldBehavior")
        public String fieldBehavior;

        /**
         * <strong>example:</strong>
         * <p>textField_xxx</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        public static GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail self = new GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail setFieldBehavior(String fieldBehavior) {
            this.fieldBehavior = fieldBehavior;
            return this;
        }
        public String getFieldBehavior() {
            return this.fieldBehavior;
        }

        public GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyFlowConfig extends TeaModel {
        @NameInMap("sid_instDetail")
        public java.util.List<GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail> sidInstDetail;

        public static GetProcessDesignByCodeResponseBodyFlowConfig build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyFlowConfig self = new GetProcessDesignByCodeResponseBodyFlowConfig();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyFlowConfig setSidInstDetail(java.util.List<GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail> sidInstDetail) {
            this.sidInstDetail = sidInstDetail;
            return this;
        }
        public java.util.List<GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail> getSidInstDetail() {
            return this.sidInstDetail;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyFormulaRulesName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>zhangsan</p>
         */
        @NameInMap("en_US")
        public String enUS;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("zh_CN")
        public String zhCN;

        public static GetProcessDesignByCodeResponseBodyFormulaRulesName build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyFormulaRulesName self = new GetProcessDesignByCodeResponseBodyFormulaRulesName();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyFormulaRulesName setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRulesName setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyFormulaRulesRule extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>EQ(#{textField_xxx},1)</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>EQ(单行文本,1)</p>
         */
        @NameInMap("displayRule")
        public String displayRule;

        /**
         * <strong>example:</strong>
         * <p>EQ(#{textField_xxx},1)</p>
         */
        @NameInMap("source")
        public String source;

        public static GetProcessDesignByCodeResponseBodyFormulaRulesRule build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyFormulaRulesRule self = new GetProcessDesignByCodeResponseBodyFormulaRulesRule();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyFormulaRulesRule setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRulesRule setDisplayRule(String displayRule) {
            this.displayRule = displayRule;
            return this;
        }
        public String getDisplayRule() {
            return this.displayRule;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRulesRule setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyFormulaRules extends TeaModel {
        @NameInMap("activityAction")
        public java.util.List<String> activityAction;

        @NameInMap("activityId")
        public java.util.List<String> activityId;

        /**
         * <strong>example:</strong>
         * <p>n</p>
         */
        @NameInMap("block")
        public String block;

        /**
         * <strong>example:</strong>
         * <p>xxx</p>
         */
        @NameInMap("message")
        public String message;

        @NameInMap("name")
        public GetProcessDesignByCodeResponseBodyFormulaRulesName name;

        /**
         * <strong>example:</strong>
         * <p>START</p>
         */
        @NameInMap("nodeType")
        public String nodeType;

        @NameInMap("rule")
        public GetProcessDesignByCodeResponseBodyFormulaRulesRule rule;

        /**
         * <strong>example:</strong>
         * <p>VALIDATOR</p>
         */
        @NameInMap("ruleType")
        public String ruleType;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("triggerMode")
        public String triggerMode;

        public static GetProcessDesignByCodeResponseBodyFormulaRules build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyFormulaRules self = new GetProcessDesignByCodeResponseBodyFormulaRules();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setActivityAction(java.util.List<String> activityAction) {
            this.activityAction = activityAction;
            return this;
        }
        public java.util.List<String> getActivityAction() {
            return this.activityAction;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setActivityId(java.util.List<String> activityId) {
            this.activityId = activityId;
            return this;
        }
        public java.util.List<String> getActivityId() {
            return this.activityId;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setBlock(String block) {
            this.block = block;
            return this;
        }
        public String getBlock() {
            return this.block;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setName(GetProcessDesignByCodeResponseBodyFormulaRulesName name) {
            this.name = name;
            return this;
        }
        public GetProcessDesignByCodeResponseBodyFormulaRulesName getName() {
            return this.name;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setNodeType(String nodeType) {
            this.nodeType = nodeType;
            return this;
        }
        public String getNodeType() {
            return this.nodeType;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setRule(GetProcessDesignByCodeResponseBodyFormulaRulesRule rule) {
            this.rule = rule;
            return this;
        }
        public GetProcessDesignByCodeResponseBodyFormulaRulesRule getRule() {
            return this.rule;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setRuleType(String ruleType) {
            this.ruleType = ruleType;
            return this;
        }
        public String getRuleType() {
            return this.ruleType;
        }

        public GetProcessDesignByCodeResponseBodyFormulaRules setTriggerMode(String triggerMode) {
            this.triggerMode = triggerMode;
            return this;
        }
        public String getTriggerMode() {
            return this.triggerMode;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyNodesName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("en_US")
        public String enUS;

        /**
         * <strong>example:</strong>
         * <p>zhangsan</p>
         */
        @NameInMap("zh_CN")
        public String zhCN;

        public static GetProcessDesignByCodeResponseBodyNodesName build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyNodesName self = new GetProcessDesignByCodeResponseBodyNodesName();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyNodesName setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetProcessDesignByCodeResponseBodyNodesName setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyNodes extends TeaModel {
        @NameInMap("childNodes")
        public java.util.List<java.util.Map<String, ?>> childNodes;

        /**
         * <strong>example:</strong>
         * <p>请选择审批人</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public GetProcessDesignByCodeResponseBodyNodesName name;

        @NameInMap("nextId")
        public java.util.List<String> nextId;

        /**
         * <strong>example:</strong>
         * <p>node_xxx</p>
         */
        @NameInMap("nodeId")
        public String nodeId;

        /**
         * <strong>example:</strong>
         * <p>node_xxx</p>
         */
        @NameInMap("prevId")
        public String prevId;

        @NameInMap("props")
        public java.util.Map<String, ?> props;

        /**
         * <strong>example:</strong>
         * <p>approval</p>
         */
        @NameInMap("type")
        public String type;

        public static GetProcessDesignByCodeResponseBodyNodes build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyNodes self = new GetProcessDesignByCodeResponseBodyNodes();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyNodes setChildNodes(java.util.List<java.util.Map<String, ?>> childNodes) {
            this.childNodes = childNodes;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getChildNodes() {
            return this.childNodes;
        }

        public GetProcessDesignByCodeResponseBodyNodes setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetProcessDesignByCodeResponseBodyNodes setName(GetProcessDesignByCodeResponseBodyNodesName name) {
            this.name = name;
            return this;
        }
        public GetProcessDesignByCodeResponseBodyNodesName getName() {
            return this.name;
        }

        public GetProcessDesignByCodeResponseBodyNodes setNextId(java.util.List<String> nextId) {
            this.nextId = nextId;
            return this;
        }
        public java.util.List<String> getNextId() {
            return this.nextId;
        }

        public GetProcessDesignByCodeResponseBodyNodes setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetProcessDesignByCodeResponseBodyNodes setPrevId(String prevId) {
            this.prevId = prevId;
            return this;
        }
        public String getPrevId() {
            return this.prevId;
        }

        public GetProcessDesignByCodeResponseBodyNodes setProps(java.util.Map<String, ?> props) {
            this.props = props;
            return this;
        }
        public java.util.Map<String, ?> getProps() {
            return this.props;
        }

        public GetProcessDesignByCodeResponseBodyNodes setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetProcessDesignByCodeResponseBodyProps extends TeaModel {
        @NameInMap("allowCollaboration")
        public Boolean allowCollaboration;

        @NameInMap("allowTemporaryStorage")
        public Boolean allowTemporaryStorage;

        @NameInMap("allowWithdraw")
        public Boolean allowWithdraw;

        /**
         * <strong>example:</strong>
         * <p>FORM-xxx</p>
         */
        @NameInMap("bindingForm")
        public String bindingForm;

        @NameInMap("noRecordRecall")
        public Boolean noRecordRecall;

        /**
         * <strong>example:</strong>
         * <p>TPROC--BDC66HB1FIPNPCMNE5VV787RY4D5327NBKTZL0</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xxx">https://xxx</a></p>
         */
        @NameInMap("processDetailUrl")
        public String processDetailUrl;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xxx">https://xxx</a></p>
         */
        @NameInMap("processInitUrl")
        public String processInitUrl;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xxx">https://xxx</a></p>
         */
        @NameInMap("processMobileDetailUrl")
        public String processMobileDetailUrl;

        @NameInMap("stopAssociationRulesIfFailed")
        public Boolean stopAssociationRulesIfFailed;

        public static GetProcessDesignByCodeResponseBodyProps build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignByCodeResponseBodyProps self = new GetProcessDesignByCodeResponseBodyProps();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignByCodeResponseBodyProps setAllowCollaboration(Boolean allowCollaboration) {
            this.allowCollaboration = allowCollaboration;
            return this;
        }
        public Boolean getAllowCollaboration() {
            return this.allowCollaboration;
        }

        public GetProcessDesignByCodeResponseBodyProps setAllowTemporaryStorage(Boolean allowTemporaryStorage) {
            this.allowTemporaryStorage = allowTemporaryStorage;
            return this;
        }
        public Boolean getAllowTemporaryStorage() {
            return this.allowTemporaryStorage;
        }

        public GetProcessDesignByCodeResponseBodyProps setAllowWithdraw(Boolean allowWithdraw) {
            this.allowWithdraw = allowWithdraw;
            return this;
        }
        public Boolean getAllowWithdraw() {
            return this.allowWithdraw;
        }

        public GetProcessDesignByCodeResponseBodyProps setBindingForm(String bindingForm) {
            this.bindingForm = bindingForm;
            return this;
        }
        public String getBindingForm() {
            return this.bindingForm;
        }

        public GetProcessDesignByCodeResponseBodyProps setNoRecordRecall(Boolean noRecordRecall) {
            this.noRecordRecall = noRecordRecall;
            return this;
        }
        public Boolean getNoRecordRecall() {
            return this.noRecordRecall;
        }

        public GetProcessDesignByCodeResponseBodyProps setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetProcessDesignByCodeResponseBodyProps setProcessDetailUrl(String processDetailUrl) {
            this.processDetailUrl = processDetailUrl;
            return this;
        }
        public String getProcessDetailUrl() {
            return this.processDetailUrl;
        }

        public GetProcessDesignByCodeResponseBodyProps setProcessInitUrl(String processInitUrl) {
            this.processInitUrl = processInitUrl;
            return this;
        }
        public String getProcessInitUrl() {
            return this.processInitUrl;
        }

        public GetProcessDesignByCodeResponseBodyProps setProcessMobileDetailUrl(String processMobileDetailUrl) {
            this.processMobileDetailUrl = processMobileDetailUrl;
            return this;
        }
        public String getProcessMobileDetailUrl() {
            return this.processMobileDetailUrl;
        }

        public GetProcessDesignByCodeResponseBodyProps setStopAssociationRulesIfFailed(Boolean stopAssociationRulesIfFailed) {
            this.stopAssociationRulesIfFailed = stopAssociationRulesIfFailed;
            return this;
        }
        public Boolean getStopAssociationRulesIfFailed() {
            return this.stopAssociationRulesIfFailed;
        }

    }

}
