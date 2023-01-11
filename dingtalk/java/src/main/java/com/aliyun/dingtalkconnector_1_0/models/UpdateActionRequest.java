// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateActionRequest extends TeaModel {
    @NameInMap("actionInfo")
    public java.util.List<UpdateActionRequestActionInfo> actionInfo;

    @NameInMap("integratorFlag")
    public String integratorFlag;

    public static UpdateActionRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateActionRequest self = new UpdateActionRequest();
        return TeaModel.build(map, self);
    }

    public UpdateActionRequest setActionInfo(java.util.List<UpdateActionRequestActionInfo> actionInfo) {
        this.actionInfo = actionInfo;
        return this;
    }
    public java.util.List<UpdateActionRequestActionInfo> getActionInfo() {
        return this.actionInfo;
    }

    public UpdateActionRequest setIntegratorFlag(String integratorFlag) {
        this.integratorFlag = integratorFlag;
        return this;
    }
    public String getIntegratorFlag() {
        return this.integratorFlag;
    }

    public static class UpdateActionRequestActionInfoInputMappingConfig extends TeaModel {
        @NameInMap("customSchemaMapping")
        public String customSchemaMapping;

        @NameInMap("rules")
        public String rules;

        public static UpdateActionRequestActionInfoInputMappingConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateActionRequestActionInfoInputMappingConfig self = new UpdateActionRequestActionInfoInputMappingConfig();
            return TeaModel.build(map, self);
        }

        public UpdateActionRequestActionInfoInputMappingConfig setCustomSchemaMapping(String customSchemaMapping) {
            this.customSchemaMapping = customSchemaMapping;
            return this;
        }
        public String getCustomSchemaMapping() {
            return this.customSchemaMapping;
        }

        public UpdateActionRequestActionInfoInputMappingConfig setRules(String rules) {
            this.rules = rules;
            return this;
        }
        public String getRules() {
            return this.rules;
        }

    }

    public static class UpdateActionRequestActionInfoOutputDataRules extends TeaModel {
        /**
         * <p>规则的预期值。</p>
         */
        @NameInMap("expectValue")
        public String expectValue;

        /**
         * <p>操作类型。</p>
         */
        @NameInMap("operate")
        public String operate;

        /**
         * <p>规则的属性路径。</p>
         */
        @NameInMap("propertyPath")
        public String propertyPath;

        public static UpdateActionRequestActionInfoOutputDataRules build(java.util.Map<String, ?> map) throws Exception {
            UpdateActionRequestActionInfoOutputDataRules self = new UpdateActionRequestActionInfoOutputDataRules();
            return TeaModel.build(map, self);
        }

        public UpdateActionRequestActionInfoOutputDataRules setExpectValue(String expectValue) {
            this.expectValue = expectValue;
            return this;
        }
        public String getExpectValue() {
            return this.expectValue;
        }

        public UpdateActionRequestActionInfoOutputDataRules setOperate(String operate) {
            this.operate = operate;
            return this;
        }
        public String getOperate() {
            return this.operate;
        }

        public UpdateActionRequestActionInfoOutputDataRules setPropertyPath(String propertyPath) {
            this.propertyPath = propertyPath;
            return this;
        }
        public String getPropertyPath() {
            return this.propertyPath;
        }

    }

    public static class UpdateActionRequestActionInfoOutputMappingConfig extends TeaModel {
        @NameInMap("customSchemaMapping")
        public String customSchemaMapping;

        @NameInMap("rules")
        public String rules;

        public static UpdateActionRequestActionInfoOutputMappingConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateActionRequestActionInfoOutputMappingConfig self = new UpdateActionRequestActionInfoOutputMappingConfig();
            return TeaModel.build(map, self);
        }

        public UpdateActionRequestActionInfoOutputMappingConfig setCustomSchemaMapping(String customSchemaMapping) {
            this.customSchemaMapping = customSchemaMapping;
            return this;
        }
        public String getCustomSchemaMapping() {
            return this.customSchemaMapping;
        }

        public UpdateActionRequestActionInfoOutputMappingConfig setRules(String rules) {
            this.rules = rules;
            return this;
        }
        public String getRules() {
            return this.rules;
        }

    }

    public static class UpdateActionRequestActionInfo extends TeaModel {
        /**
         * <p>api请求url path，结合Connector上的apiDomain使用</p>
         */
        @NameInMap("apiPath")
        public String apiPath;

        /**
         * <p>描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>连接平台的执行动作唯一标识。</p>
         */
        @NameInMap("dingActionId")
        public String dingActionId;

        /**
         * <p>连接平台连接器id</p>
         */
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        @NameInMap("inputMappingConfig")
        public UpdateActionRequestActionInfoInputMappingConfig inputMappingConfig;

        /**
         * <p>入参schema</p>
         */
        @NameInMap("inputSchema")
        public String inputSchema;

        /**
         * <p>服务商的执行事件Id</p>
         */
        @NameInMap("integratorActionId")
        public String integratorActionId;

        /**
         * <p>服务商的连接器Id</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>执行动作接口成功调用规则。</p>
         */
        @NameInMap("outputDataRules")
        public java.util.List<UpdateActionRequestActionInfoOutputDataRules> outputDataRules;

        @NameInMap("outputMappingConfig")
        public UpdateActionRequestActionInfoOutputMappingConfig outputMappingConfig;

        /**
         * <p>出参schema</p>
         */
        @NameInMap("outputSchema")
        public String outputSchema;

        public static UpdateActionRequestActionInfo build(java.util.Map<String, ?> map) throws Exception {
            UpdateActionRequestActionInfo self = new UpdateActionRequestActionInfo();
            return TeaModel.build(map, self);
        }

        public UpdateActionRequestActionInfo setApiPath(String apiPath) {
            this.apiPath = apiPath;
            return this;
        }
        public String getApiPath() {
            return this.apiPath;
        }

        public UpdateActionRequestActionInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UpdateActionRequestActionInfo setDingActionId(String dingActionId) {
            this.dingActionId = dingActionId;
            return this;
        }
        public String getDingActionId() {
            return this.dingActionId;
        }

        public UpdateActionRequestActionInfo setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public UpdateActionRequestActionInfo setInputMappingConfig(UpdateActionRequestActionInfoInputMappingConfig inputMappingConfig) {
            this.inputMappingConfig = inputMappingConfig;
            return this;
        }
        public UpdateActionRequestActionInfoInputMappingConfig getInputMappingConfig() {
            return this.inputMappingConfig;
        }

        public UpdateActionRequestActionInfo setInputSchema(String inputSchema) {
            this.inputSchema = inputSchema;
            return this;
        }
        public String getInputSchema() {
            return this.inputSchema;
        }

        public UpdateActionRequestActionInfo setIntegratorActionId(String integratorActionId) {
            this.integratorActionId = integratorActionId;
            return this;
        }
        public String getIntegratorActionId() {
            return this.integratorActionId;
        }

        public UpdateActionRequestActionInfo setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public UpdateActionRequestActionInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateActionRequestActionInfo setOutputDataRules(java.util.List<UpdateActionRequestActionInfoOutputDataRules> outputDataRules) {
            this.outputDataRules = outputDataRules;
            return this;
        }
        public java.util.List<UpdateActionRequestActionInfoOutputDataRules> getOutputDataRules() {
            return this.outputDataRules;
        }

        public UpdateActionRequestActionInfo setOutputMappingConfig(UpdateActionRequestActionInfoOutputMappingConfig outputMappingConfig) {
            this.outputMappingConfig = outputMappingConfig;
            return this;
        }
        public UpdateActionRequestActionInfoOutputMappingConfig getOutputMappingConfig() {
            return this.outputMappingConfig;
        }

        public UpdateActionRequestActionInfo setOutputSchema(String outputSchema) {
            this.outputSchema = outputSchema;
            return this;
        }
        public String getOutputSchema() {
            return this.outputSchema;
        }

    }

}
