// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ReadPersonalMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingOpenConversationMessageIdArray")
    public java.util.List<ReadPersonalMessageRequestDingOpenConversationMessageIdArray> dingOpenConversationMessageIdArray;

    public static ReadPersonalMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        ReadPersonalMessageRequest self = new ReadPersonalMessageRequest();
        return TeaModel.build(map, self);
    }

    public ReadPersonalMessageRequest setDingOpenConversationMessageIdArray(java.util.List<ReadPersonalMessageRequestDingOpenConversationMessageIdArray> dingOpenConversationMessageIdArray) {
        this.dingOpenConversationMessageIdArray = dingOpenConversationMessageIdArray;
        return this;
    }
    public java.util.List<ReadPersonalMessageRequestDingOpenConversationMessageIdArray> getDingOpenConversationMessageIdArray() {
        return this.dingOpenConversationMessageIdArray;
    }

    public static class ReadPersonalMessageRequestDingOpenConversationMessageIdArray extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>cidQGfKJCXMfVxZxxx3ZL0Qlw</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>msghnezLi8wb6pGqMsadhj9n0yw</p>
         */
        @NameInMap("openMessageId")
        public String openMessageId;

        public static ReadPersonalMessageRequestDingOpenConversationMessageIdArray build(java.util.Map<String, ?> map) throws Exception {
            ReadPersonalMessageRequestDingOpenConversationMessageIdArray self = new ReadPersonalMessageRequestDingOpenConversationMessageIdArray();
            return TeaModel.build(map, self);
        }

        public ReadPersonalMessageRequestDingOpenConversationMessageIdArray setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public ReadPersonalMessageRequestDingOpenConversationMessageIdArray setOpenMessageId(String openMessageId) {
            this.openMessageId = openMessageId;
            return this;
        }
        public String getOpenMessageId() {
            return this.openMessageId;
        }

    }

}
