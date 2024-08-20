// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDesignResponseBody extends TeaModel {
    @NameInMap("approvalSummary")
    public java.util.List<GetProcessDesignResponseBodyApprovalSummary> approvalSummary;

    @NameInMap("flowConfig")
    public GetProcessDesignResponseBodyFlowConfig flowConfig;

    @NameInMap("formulaRules")
    public java.util.List<GetProcessDesignResponseBodyFormulaRules> formulaRules;

    @NameInMap("nodes")
    public java.util.List<GetProcessDesignResponseBodyNodes> nodes;

    @NameInMap("props")
    public GetProcessDesignResponseBodyProps props;

    public static GetProcessDesignResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDesignResponseBody self = new GetProcessDesignResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessDesignResponseBody setApprovalSummary(java.util.List<GetProcessDesignResponseBodyApprovalSummary> approvalSummary) {
        this.approvalSummary = approvalSummary;
        return this;
    }
    public java.util.List<GetProcessDesignResponseBodyApprovalSummary> getApprovalSummary() {
        return this.approvalSummary;
    }

    public GetProcessDesignResponseBody setFlowConfig(GetProcessDesignResponseBodyFlowConfig flowConfig) {
        this.flowConfig = flowConfig;
        return this;
    }
    public GetProcessDesignResponseBodyFlowConfig getFlowConfig() {
        return this.flowConfig;
    }

    public GetProcessDesignResponseBody setFormulaRules(java.util.List<GetProcessDesignResponseBodyFormulaRules> formulaRules) {
        this.formulaRules = formulaRules;
        return this;
    }
    public java.util.List<GetProcessDesignResponseBodyFormulaRules> getFormulaRules() {
        return this.formulaRules;
    }

    public GetProcessDesignResponseBody setNodes(java.util.List<GetProcessDesignResponseBodyNodes> nodes) {
        this.nodes = nodes;
        return this;
    }
    public java.util.List<GetProcessDesignResponseBodyNodes> getNodes() {
        return this.nodes;
    }

    public GetProcessDesignResponseBody setProps(GetProcessDesignResponseBodyProps props) {
        this.props = props;
        return this;
    }
    public GetProcessDesignResponseBodyProps getProps() {
        return this.props;
    }

    public static class GetProcessDesignResponseBodyApprovalSummaryTitle extends TeaModel {
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

        public static GetProcessDesignResponseBodyApprovalSummaryTitle build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyApprovalSummaryTitle self = new GetProcessDesignResponseBodyApprovalSummaryTitle();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyApprovalSummaryTitle setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetProcessDesignResponseBodyApprovalSummaryTitle setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetProcessDesignResponseBodyApprovalSummaryTitle setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetProcessDesignResponseBodyApprovalSummary extends TeaModel {
        @NameInMap("title")
        public GetProcessDesignResponseBodyApprovalSummaryTitle title;

        public static GetProcessDesignResponseBodyApprovalSummary build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyApprovalSummary self = new GetProcessDesignResponseBodyApprovalSummary();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyApprovalSummary setTitle(GetProcessDesignResponseBodyApprovalSummaryTitle title) {
            this.title = title;
            return this;
        }
        public GetProcessDesignResponseBodyApprovalSummaryTitle getTitle() {
            return this.title;
        }

    }

    public static class GetProcessDesignResponseBodyFlowConfigSidInstDetail extends TeaModel {
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

        public static GetProcessDesignResponseBodyFlowConfigSidInstDetail build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyFlowConfigSidInstDetail self = new GetProcessDesignResponseBodyFlowConfigSidInstDetail();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyFlowConfigSidInstDetail setFieldBehavior(String fieldBehavior) {
            this.fieldBehavior = fieldBehavior;
            return this;
        }
        public String getFieldBehavior() {
            return this.fieldBehavior;
        }

        public GetProcessDesignResponseBodyFlowConfigSidInstDetail setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class GetProcessDesignResponseBodyFlowConfig extends TeaModel {
        @NameInMap("sid_instDetail")
        public java.util.List<GetProcessDesignResponseBodyFlowConfigSidInstDetail> sidInstDetail;

        public static GetProcessDesignResponseBodyFlowConfig build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyFlowConfig self = new GetProcessDesignResponseBodyFlowConfig();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyFlowConfig setSidInstDetail(java.util.List<GetProcessDesignResponseBodyFlowConfigSidInstDetail> sidInstDetail) {
            this.sidInstDetail = sidInstDetail;
            return this;
        }
        public java.util.List<GetProcessDesignResponseBodyFlowConfigSidInstDetail> getSidInstDetail() {
            return this.sidInstDetail;
        }

    }

    public static class GetProcessDesignResponseBodyFormulaRulesName extends TeaModel {
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

        public static GetProcessDesignResponseBodyFormulaRulesName build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyFormulaRulesName self = new GetProcessDesignResponseBodyFormulaRulesName();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyFormulaRulesName setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetProcessDesignResponseBodyFormulaRulesName setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetProcessDesignResponseBodyFormulaRulesRule extends TeaModel {
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

        public static GetProcessDesignResponseBodyFormulaRulesRule build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyFormulaRulesRule self = new GetProcessDesignResponseBodyFormulaRulesRule();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyFormulaRulesRule setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetProcessDesignResponseBodyFormulaRulesRule setDisplayRule(String displayRule) {
            this.displayRule = displayRule;
            return this;
        }
        public String getDisplayRule() {
            return this.displayRule;
        }

        public GetProcessDesignResponseBodyFormulaRulesRule setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

    public static class GetProcessDesignResponseBodyFormulaRules extends TeaModel {
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
        public GetProcessDesignResponseBodyFormulaRulesName name;

        /**
         * <strong>example:</strong>
         * <p>START</p>
         */
        @NameInMap("nodeType")
        public String nodeType;

        @NameInMap("rule")
        public GetProcessDesignResponseBodyFormulaRulesRule rule;

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

        public static GetProcessDesignResponseBodyFormulaRules build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyFormulaRules self = new GetProcessDesignResponseBodyFormulaRules();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyFormulaRules setActivityAction(java.util.List<String> activityAction) {
            this.activityAction = activityAction;
            return this;
        }
        public java.util.List<String> getActivityAction() {
            return this.activityAction;
        }

        public GetProcessDesignResponseBodyFormulaRules setActivityId(java.util.List<String> activityId) {
            this.activityId = activityId;
            return this;
        }
        public java.util.List<String> getActivityId() {
            return this.activityId;
        }

        public GetProcessDesignResponseBodyFormulaRules setBlock(String block) {
            this.block = block;
            return this;
        }
        public String getBlock() {
            return this.block;
        }

        public GetProcessDesignResponseBodyFormulaRules setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public GetProcessDesignResponseBodyFormulaRules setName(GetProcessDesignResponseBodyFormulaRulesName name) {
            this.name = name;
            return this;
        }
        public GetProcessDesignResponseBodyFormulaRulesName getName() {
            return this.name;
        }

        public GetProcessDesignResponseBodyFormulaRules setNodeType(String nodeType) {
            this.nodeType = nodeType;
            return this;
        }
        public String getNodeType() {
            return this.nodeType;
        }

        public GetProcessDesignResponseBodyFormulaRules setRule(GetProcessDesignResponseBodyFormulaRulesRule rule) {
            this.rule = rule;
            return this;
        }
        public GetProcessDesignResponseBodyFormulaRulesRule getRule() {
            return this.rule;
        }

        public GetProcessDesignResponseBodyFormulaRules setRuleType(String ruleType) {
            this.ruleType = ruleType;
            return this;
        }
        public String getRuleType() {
            return this.ruleType;
        }

        public GetProcessDesignResponseBodyFormulaRules setTriggerMode(String triggerMode) {
            this.triggerMode = triggerMode;
            return this;
        }
        public String getTriggerMode() {
            return this.triggerMode;
        }

    }

    public static class GetProcessDesignResponseBodyNodesName extends TeaModel {
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

        public static GetProcessDesignResponseBodyNodesName build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyNodesName self = new GetProcessDesignResponseBodyNodesName();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyNodesName setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetProcessDesignResponseBodyNodesName setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetProcessDesignResponseBodyNodes extends TeaModel {
        @NameInMap("childNodes")
        public java.util.List<java.util.Map<String, ?>> childNodes;

        /**
         * <strong>example:</strong>
         * <p>请选择审批人</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public GetProcessDesignResponseBodyNodesName name;

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

        public static GetProcessDesignResponseBodyNodes build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyNodes self = new GetProcessDesignResponseBodyNodes();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyNodes setChildNodes(java.util.List<java.util.Map<String, ?>> childNodes) {
            this.childNodes = childNodes;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getChildNodes() {
            return this.childNodes;
        }

        public GetProcessDesignResponseBodyNodes setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetProcessDesignResponseBodyNodes setName(GetProcessDesignResponseBodyNodesName name) {
            this.name = name;
            return this;
        }
        public GetProcessDesignResponseBodyNodesName getName() {
            return this.name;
        }

        public GetProcessDesignResponseBodyNodes setNextId(java.util.List<String> nextId) {
            this.nextId = nextId;
            return this;
        }
        public java.util.List<String> getNextId() {
            return this.nextId;
        }

        public GetProcessDesignResponseBodyNodes setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetProcessDesignResponseBodyNodes setPrevId(String prevId) {
            this.prevId = prevId;
            return this;
        }
        public String getPrevId() {
            return this.prevId;
        }

        public GetProcessDesignResponseBodyNodes setProps(java.util.Map<String, ?> props) {
            this.props = props;
            return this;
        }
        public java.util.Map<String, ?> getProps() {
            return this.props;
        }

        public GetProcessDesignResponseBodyNodes setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetProcessDesignResponseBodyProps extends TeaModel {
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

        public static GetProcessDesignResponseBodyProps build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDesignResponseBodyProps self = new GetProcessDesignResponseBodyProps();
            return TeaModel.build(map, self);
        }

        public GetProcessDesignResponseBodyProps setAllowCollaboration(Boolean allowCollaboration) {
            this.allowCollaboration = allowCollaboration;
            return this;
        }
        public Boolean getAllowCollaboration() {
            return this.allowCollaboration;
        }

        public GetProcessDesignResponseBodyProps setAllowTemporaryStorage(Boolean allowTemporaryStorage) {
            this.allowTemporaryStorage = allowTemporaryStorage;
            return this;
        }
        public Boolean getAllowTemporaryStorage() {
            return this.allowTemporaryStorage;
        }

        public GetProcessDesignResponseBodyProps setAllowWithdraw(Boolean allowWithdraw) {
            this.allowWithdraw = allowWithdraw;
            return this;
        }
        public Boolean getAllowWithdraw() {
            return this.allowWithdraw;
        }

        public GetProcessDesignResponseBodyProps setBindingForm(String bindingForm) {
            this.bindingForm = bindingForm;
            return this;
        }
        public String getBindingForm() {
            return this.bindingForm;
        }

        public GetProcessDesignResponseBodyProps setNoRecordRecall(Boolean noRecordRecall) {
            this.noRecordRecall = noRecordRecall;
            return this;
        }
        public Boolean getNoRecordRecall() {
            return this.noRecordRecall;
        }

        public GetProcessDesignResponseBodyProps setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetProcessDesignResponseBodyProps setProcessDetailUrl(String processDetailUrl) {
            this.processDetailUrl = processDetailUrl;
            return this;
        }
        public String getProcessDetailUrl() {
            return this.processDetailUrl;
        }

        public GetProcessDesignResponseBodyProps setProcessInitUrl(String processInitUrl) {
            this.processInitUrl = processInitUrl;
            return this;
        }
        public String getProcessInitUrl() {
            return this.processInitUrl;
        }

        public GetProcessDesignResponseBodyProps setProcessMobileDetailUrl(String processMobileDetailUrl) {
            this.processMobileDetailUrl = processMobileDetailUrl;
            return this;
        }
        public String getProcessMobileDetailUrl() {
            return this.processMobileDetailUrl;
        }

        public GetProcessDesignResponseBodyProps setStopAssociationRulesIfFailed(Boolean stopAssociationRulesIfFailed) {
            this.stopAssociationRulesIfFailed = stopAssociationRulesIfFailed;
            return this;
        }
        public Boolean getStopAssociationRulesIfFailed() {
            return this.stopAssociationRulesIfFailed;
        }

    }

}
