// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterEventTypeRequest extends TeaModel {
    // 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
    @NameInMap("corpId")
    public String corpId;

    // 事件类型列表，最多支持添加500个。
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
        // 事件类型(唯一)，最长20个字符。
        @NameInMap("eventType")
        public String eventType;

        // 事件类型名称，长度4-20个字符，一个中文汉字算2个字符。
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
