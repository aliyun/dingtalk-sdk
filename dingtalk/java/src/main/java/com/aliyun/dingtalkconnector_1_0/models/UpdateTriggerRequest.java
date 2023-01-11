// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateTriggerRequest extends TeaModel {
    @NameInMap("integratorFlag")
    public String integratorFlag;

    @NameInMap("triggerInfo")
    public java.util.List<UpdateTriggerRequestTriggerInfo> triggerInfo;

    public static UpdateTriggerRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTriggerRequest self = new UpdateTriggerRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTriggerRequest setIntegratorFlag(String integratorFlag) {
        this.integratorFlag = integratorFlag;
        return this;
    }
    public String getIntegratorFlag() {
        return this.integratorFlag;
    }

    public UpdateTriggerRequest setTriggerInfo(java.util.List<UpdateTriggerRequestTriggerInfo> triggerInfo) {
        this.triggerInfo = triggerInfo;
        return this;
    }
    public java.util.List<UpdateTriggerRequestTriggerInfo> getTriggerInfo() {
        return this.triggerInfo;
    }

    public static class UpdateTriggerRequestTriggerInfo extends TeaModel {
        /**
         * <p>触发事件描述。</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>连接平台连接器唯一标识。</p>
         */
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        /**
         * <p>连接平台触发事件唯一标识。</p>
         */
        @NameInMap("dingTriggerId")
        public String dingTriggerId;

        /**
         * <p>入参属性描述。</p>
         */
        @NameInMap("inputSchema")
        public String inputSchema;

        /**
         * <p>服务商的连接器唯一标识。</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>服务商的触发事件唯一标识。</p>
         */
        @NameInMap("integratorTriggerId")
        public String integratorTriggerId;

        /**
         * <p>触发事件名称。</p>
         */
        @NameInMap("name")
        public String name;

        public static UpdateTriggerRequestTriggerInfo build(java.util.Map<String, ?> map) throws Exception {
            UpdateTriggerRequestTriggerInfo self = new UpdateTriggerRequestTriggerInfo();
            return TeaModel.build(map, self);
        }

        public UpdateTriggerRequestTriggerInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UpdateTriggerRequestTriggerInfo setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public UpdateTriggerRequestTriggerInfo setDingTriggerId(String dingTriggerId) {
            this.dingTriggerId = dingTriggerId;
            return this;
        }
        public String getDingTriggerId() {
            return this.dingTriggerId;
        }

        public UpdateTriggerRequestTriggerInfo setInputSchema(String inputSchema) {
            this.inputSchema = inputSchema;
            return this;
        }
        public String getInputSchema() {
            return this.inputSchema;
        }

        public UpdateTriggerRequestTriggerInfo setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public UpdateTriggerRequestTriggerInfo setIntegratorTriggerId(String integratorTriggerId) {
            this.integratorTriggerId = integratorTriggerId;
            return this;
        }
        public String getIntegratorTriggerId() {
            return this.integratorTriggerId;
        }

        public UpdateTriggerRequestTriggerInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
