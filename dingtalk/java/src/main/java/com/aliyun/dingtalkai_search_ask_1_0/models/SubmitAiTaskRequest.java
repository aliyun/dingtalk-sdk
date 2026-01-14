// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiTaskRequest extends TeaModel {
    @NameInMap("messages")
    public java.util.List<SubmitAiTaskRequestMessages> messages;

    public static SubmitAiTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiTaskRequest self = new SubmitAiTaskRequest();
        return TeaModel.build(map, self);
    }

    public SubmitAiTaskRequest setMessages(java.util.List<SubmitAiTaskRequestMessages> messages) {
        this.messages = messages;
        return this;
    }
    public java.util.List<SubmitAiTaskRequestMessages> getMessages() {
        return this.messages;
    }

    public static class SubmitAiTaskRequestMessages extends TeaModel {
        @NameInMap("content")
        public String content;

        public static SubmitAiTaskRequestMessages build(java.util.Map<String, ?> map) throws Exception {
            SubmitAiTaskRequestMessages self = new SubmitAiTaskRequestMessages();
            return TeaModel.build(map, self);
        }

        public SubmitAiTaskRequestMessages setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
