// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreConversationsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<DigitalStoreConversationsResponseBodyContent> content;

    public static DigitalStoreConversationsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreConversationsResponseBody self = new DigitalStoreConversationsResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreConversationsResponseBody setContent(java.util.List<DigitalStoreConversationsResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStoreConversationsResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStoreConversationsResponseBodyContent extends TeaModel {
        @NameInMap("conversationTitle")
        public String conversationTitle;

        @NameInMap("conversationType")
        public String conversationType;

        @NameInMap("id")
        public Long id;

        public static DigitalStoreConversationsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreConversationsResponseBodyContent self = new DigitalStoreConversationsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreConversationsResponseBodyContent setConversationTitle(String conversationTitle) {
            this.conversationTitle = conversationTitle;
            return this;
        }
        public String getConversationTitle() {
            return this.conversationTitle;
        }

        public DigitalStoreConversationsResponseBodyContent setConversationType(String conversationType) {
            this.conversationType = conversationType;
            return this;
        }
        public String getConversationType() {
            return this.conversationType;
        }

        public DigitalStoreConversationsResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

}
