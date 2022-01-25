// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateTriggerRequest extends TeaModel {
    @NameInMap("triggerInfo")
    public java.util.List<CreateTriggerRequestTriggerInfo> triggerInfo;

    public static CreateTriggerRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTriggerRequest self = new CreateTriggerRequest();
        return TeaModel.build(map, self);
    }

    public CreateTriggerRequest setTriggerInfo(java.util.List<CreateTriggerRequestTriggerInfo> triggerInfo) {
        this.triggerInfo = triggerInfo;
        return this;
    }
    public java.util.List<CreateTriggerRequestTriggerInfo> getTriggerInfo() {
        return this.triggerInfo;
    }

    public static class CreateTriggerRequestTriggerInfo extends TeaModel {
        // 描述
        @NameInMap("description")
        public String description;

        // 连接平台连接器id
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        // 入参jsonSchema
        @NameInMap("inputSchema")
        public String inputSchema;

        // 服务商的连接器Id，优先使用dingConnectorId，其次使用integratorConnectorId
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        // 服务商的触发事件Id
        @NameInMap("integratorTriggerId")
        public String integratorTriggerId;

        // 名称
        @NameInMap("name")
        public String name;

        public static CreateTriggerRequestTriggerInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateTriggerRequestTriggerInfo self = new CreateTriggerRequestTriggerInfo();
            return TeaModel.build(map, self);
        }

        public CreateTriggerRequestTriggerInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateTriggerRequestTriggerInfo setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public CreateTriggerRequestTriggerInfo setInputSchema(String inputSchema) {
            this.inputSchema = inputSchema;
            return this;
        }
        public String getInputSchema() {
            return this.inputSchema;
        }

        public CreateTriggerRequestTriggerInfo setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public CreateTriggerRequestTriggerInfo setIntegratorTriggerId(String integratorTriggerId) {
            this.integratorTriggerId = integratorTriggerId;
            return this;
        }
        public String getIntegratorTriggerId() {
            return this.integratorTriggerId;
        }

        public CreateTriggerRequestTriggerInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
