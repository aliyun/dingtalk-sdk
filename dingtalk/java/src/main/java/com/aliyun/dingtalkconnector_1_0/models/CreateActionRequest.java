// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateActionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionInfo")
    public java.util.List<CreateActionRequestActionInfo> actionInfo;

    @NameInMap("integratorFlag")
    public String integratorFlag;

    public static CreateActionRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateActionRequest self = new CreateActionRequest();
        return TeaModel.build(map, self);
    }

    public CreateActionRequest setActionInfo(java.util.List<CreateActionRequestActionInfo> actionInfo) {
        this.actionInfo = actionInfo;
        return this;
    }
    public java.util.List<CreateActionRequestActionInfo> getActionInfo() {
        return this.actionInfo;
    }

    public CreateActionRequest setIntegratorFlag(String integratorFlag) {
        this.integratorFlag = integratorFlag;
        return this;
    }
    public String getIntegratorFlag() {
        return this.integratorFlag;
    }

    public static class CreateActionRequestActionInfoInputMappingConfig extends TeaModel {
        @NameInMap("customSchemaMapping")
        public String customSchemaMapping;

        @NameInMap("rules")
        public String rules;

        public static CreateActionRequestActionInfoInputMappingConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateActionRequestActionInfoInputMappingConfig self = new CreateActionRequestActionInfoInputMappingConfig();
            return TeaModel.build(map, self);
        }

        public CreateActionRequestActionInfoInputMappingConfig setCustomSchemaMapping(String customSchemaMapping) {
            this.customSchemaMapping = customSchemaMapping;
            return this;
        }
        public String getCustomSchemaMapping() {
            return this.customSchemaMapping;
        }

        public CreateActionRequestActionInfoInputMappingConfig setRules(String rules) {
            this.rules = rules;
            return this;
        }
        public String getRules() {
            return this.rules;
        }

    }

    public static class CreateActionRequestActionInfoOutputDataRules extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("expectValue")
        public String expectValue;

        /**
         * <strong>example:</strong>
         * <p>EQ</p>
         */
        @NameInMap("operate")
        public String operate;

        /**
         * <strong>example:</strong>
         * <p>a/b/c</p>
         */
        @NameInMap("propertyPath")
        public String propertyPath;

        public static CreateActionRequestActionInfoOutputDataRules build(java.util.Map<String, ?> map) throws Exception {
            CreateActionRequestActionInfoOutputDataRules self = new CreateActionRequestActionInfoOutputDataRules();
            return TeaModel.build(map, self);
        }

        public CreateActionRequestActionInfoOutputDataRules setExpectValue(String expectValue) {
            this.expectValue = expectValue;
            return this;
        }
        public String getExpectValue() {
            return this.expectValue;
        }

        public CreateActionRequestActionInfoOutputDataRules setOperate(String operate) {
            this.operate = operate;
            return this;
        }
        public String getOperate() {
            return this.operate;
        }

        public CreateActionRequestActionInfoOutputDataRules setPropertyPath(String propertyPath) {
            this.propertyPath = propertyPath;
            return this;
        }
        public String getPropertyPath() {
            return this.propertyPath;
        }

    }

    public static class CreateActionRequestActionInfoOutputMappingConfig extends TeaModel {
        @NameInMap("customSchemaMapping")
        public String customSchemaMapping;

        @NameInMap("rules")
        public String rules;

        public static CreateActionRequestActionInfoOutputMappingConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateActionRequestActionInfoOutputMappingConfig self = new CreateActionRequestActionInfoOutputMappingConfig();
            return TeaModel.build(map, self);
        }

        public CreateActionRequestActionInfoOutputMappingConfig setCustomSchemaMapping(String customSchemaMapping) {
            this.customSchemaMapping = customSchemaMapping;
            return this;
        }
        public String getCustomSchemaMapping() {
            return this.customSchemaMapping;
        }

        public CreateActionRequestActionInfoOutputMappingConfig setRules(String rules) {
            this.rules = rules;
            return this;
        }
        public String getRules() {
            return this.rules;
        }

    }

    public static class CreateActionRequestActionInfo extends TeaModel {
        @NameInMap("apiPath")
        public String apiPath;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        @NameInMap("inputMappingConfig")
        public CreateActionRequestActionInfoInputMappingConfig inputMappingConfig;

        @NameInMap("inputSchema")
        public String inputSchema;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorActionId")
        public String integratorActionId;

        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("outputDataRules")
        public java.util.List<CreateActionRequestActionInfoOutputDataRules> outputDataRules;

        @NameInMap("outputMappingConfig")
        public CreateActionRequestActionInfoOutputMappingConfig outputMappingConfig;

        @NameInMap("outputSchema")
        public String outputSchema;

        public static CreateActionRequestActionInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateActionRequestActionInfo self = new CreateActionRequestActionInfo();
            return TeaModel.build(map, self);
        }

        public CreateActionRequestActionInfo setApiPath(String apiPath) {
            this.apiPath = apiPath;
            return this;
        }
        public String getApiPath() {
            return this.apiPath;
        }

        public CreateActionRequestActionInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateActionRequestActionInfo setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public CreateActionRequestActionInfo setInputMappingConfig(CreateActionRequestActionInfoInputMappingConfig inputMappingConfig) {
            this.inputMappingConfig = inputMappingConfig;
            return this;
        }
        public CreateActionRequestActionInfoInputMappingConfig getInputMappingConfig() {
            return this.inputMappingConfig;
        }

        public CreateActionRequestActionInfo setInputSchema(String inputSchema) {
            this.inputSchema = inputSchema;
            return this;
        }
        public String getInputSchema() {
            return this.inputSchema;
        }

        public CreateActionRequestActionInfo setIntegratorActionId(String integratorActionId) {
            this.integratorActionId = integratorActionId;
            return this;
        }
        public String getIntegratorActionId() {
            return this.integratorActionId;
        }

        public CreateActionRequestActionInfo setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public CreateActionRequestActionInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateActionRequestActionInfo setOutputDataRules(java.util.List<CreateActionRequestActionInfoOutputDataRules> outputDataRules) {
            this.outputDataRules = outputDataRules;
            return this;
        }
        public java.util.List<CreateActionRequestActionInfoOutputDataRules> getOutputDataRules() {
            return this.outputDataRules;
        }

        public CreateActionRequestActionInfo setOutputMappingConfig(CreateActionRequestActionInfoOutputMappingConfig outputMappingConfig) {
            this.outputMappingConfig = outputMappingConfig;
            return this;
        }
        public CreateActionRequestActionInfoOutputMappingConfig getOutputMappingConfig() {
            return this.outputMappingConfig;
        }

        public CreateActionRequestActionInfo setOutputSchema(String outputSchema) {
            this.outputSchema = outputSchema;
            return this;
        }
        public String getOutputSchema() {
            return this.outputSchema;
        }

    }

}
