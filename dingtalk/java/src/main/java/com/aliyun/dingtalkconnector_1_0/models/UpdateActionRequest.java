// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateActionRequest extends TeaModel {
    @NameInMap("actionInfo")
    public java.util.List<UpdateActionRequestActionInfo> actionInfo;

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

    public static class UpdateActionRequestActionInfoOutputDataRules extends TeaModel {
        // 规则的预期值。
        @NameInMap("expectValue")
        public String expectValue;

        // 操作类型。
        @NameInMap("operate")
        public String operate;

        // 规则的属性路径。
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

    public static class UpdateActionRequestActionInfo extends TeaModel {
        // api请求url path，结合Connector上的apiDomain使用
        @NameInMap("apiPath")
        public String apiPath;

        // 描述
        @NameInMap("description")
        public String description;

        // 连接平台的执行动作唯一标识。
        @NameInMap("dingActionId")
        public String dingActionId;

        // 连接平台连接器id
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        // 入参schema
        @NameInMap("inputSchema")
        public String inputSchema;

        // 服务商的执行事件Id
        @NameInMap("integratorActionId")
        public String integratorActionId;

        // 服务商的连接器Id
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        // 名称
        @NameInMap("name")
        public String name;

        // 执行动作接口成功调用规则。
        @NameInMap("outputDataRules")
        public java.util.List<UpdateActionRequestActionInfoOutputDataRules> outputDataRules;

        // 出参schema
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

        public UpdateActionRequestActionInfo setOutputSchema(String outputSchema) {
            this.outputSchema = outputSchema;
            return this;
        }
        public String getOutputSchema() {
            return this.outputSchema;
        }

    }

}
