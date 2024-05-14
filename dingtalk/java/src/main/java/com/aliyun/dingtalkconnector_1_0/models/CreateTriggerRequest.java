// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateTriggerRequest extends TeaModel {
    @NameInMap("integratorFlag")
    public String integratorFlag;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("triggerInfo")
    public java.util.List<CreateTriggerRequestTriggerInfo> triggerInfo;

    public static CreateTriggerRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTriggerRequest self = new CreateTriggerRequest();
        return TeaModel.build(map, self);
    }

    public CreateTriggerRequest setIntegratorFlag(String integratorFlag) {
        this.integratorFlag = integratorFlag;
        return this;
    }
    public String getIntegratorFlag() {
        return this.integratorFlag;
    }

    public CreateTriggerRequest setTriggerInfo(java.util.List<CreateTriggerRequestTriggerInfo> triggerInfo) {
        this.triggerInfo = triggerInfo;
        return this;
    }
    public java.util.List<CreateTriggerRequestTriggerInfo> getTriggerInfo() {
        return this.triggerInfo;
    }

    public static class CreateTriggerRequestTriggerInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("inputSchema")
        public String inputSchema;

        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorTriggerId")
        public String integratorTriggerId;

        /**
         * <p>This parameter is required.</p>
         */
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
