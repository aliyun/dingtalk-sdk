// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterEventTypeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding12345</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("eventTypes")
    public java.util.List<BatchRegisterEventTypeRequestEventTypes> eventTypes;

    public static BatchRegisterEventTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterEventTypeRequest self = new BatchRegisterEventTypeRequest();
        return TeaModel.build(map, self);
    }

    public BatchRegisterEventTypeRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchRegisterEventTypeRequest setEventTypes(java.util.List<BatchRegisterEventTypeRequestEventTypes> eventTypes) {
        this.eventTypes = eventTypes;
        return this;
    }
    public java.util.List<BatchRegisterEventTypeRequestEventTypes> getEventTypes() {
        return this.eventTypes;
    }

    public static class BatchRegisterEventTypeRequestEventTypes extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>fireDetect</p>
         */
        @NameInMap("eventType")
        public String eventType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>火焰告警</p>
         */
        @NameInMap("eventTypeName")
        public String eventTypeName;

        public static BatchRegisterEventTypeRequestEventTypes build(java.util.Map<String, ?> map) throws Exception {
            BatchRegisterEventTypeRequestEventTypes self = new BatchRegisterEventTypeRequestEventTypes();
            return TeaModel.build(map, self);
        }

        public BatchRegisterEventTypeRequestEventTypes setEventType(String eventType) {
            this.eventType = eventType;
            return this;
        }
        public String getEventType() {
            return this.eventType;
        }

        public BatchRegisterEventTypeRequestEventTypes setEventTypeName(String eventTypeName) {
            this.eventTypeName = eventTypeName;
            return this;
        }
        public String getEventTypeName() {
            return this.eventTypeName;
        }

    }

}
