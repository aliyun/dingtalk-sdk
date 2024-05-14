// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateActionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionInfo")
    public java.util.List<UpdateActionRequestActionInfo> actionInfo;

    /**
     * <p>This parameter is required.</p>
     */
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
        @NameInMap("expectValue")
        public String expectValue;

        @NameInMap("operate")
        public String operate;

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
        @NameInMap("apiPath")
        public String apiPath;

        @NameInMap("description")
        public String description;

        @NameInMap("dingActionId")
        public String dingActionId;

        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        @NameInMap("inputMappingConfig")
        public UpdateActionRequestActionInfoInputMappingConfig inputMappingConfig;

        @NameInMap("inputSchema")
        public String inputSchema;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorActionId")
        public String integratorActionId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        @NameInMap("name")
        public String name;

        @NameInMap("outputDataRules")
        public java.util.List<UpdateActionRequestActionInfoOutputDataRules> outputDataRules;

        @NameInMap("outputMappingConfig")
        public UpdateActionRequestActionInfoOutputMappingConfig outputMappingConfig;

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
