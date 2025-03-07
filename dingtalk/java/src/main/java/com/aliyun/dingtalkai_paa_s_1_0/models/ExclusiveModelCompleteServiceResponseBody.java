// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveModelCompleteServiceResponseBody extends TeaModel {
    @NameInMap("choices")
    public java.util.List<ExclusiveModelCompleteServiceResponseBodyChoices> choices;

    @NameInMap("created")
    public Integer created;

    @NameInMap("id")
    public String id;

    @NameInMap("model")
    public String model;

    @NameInMap("usage")
    public ExclusiveModelCompleteServiceResponseBodyUsage usage;

    public static ExclusiveModelCompleteServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveModelCompleteServiceResponseBody self = new ExclusiveModelCompleteServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public ExclusiveModelCompleteServiceResponseBody setChoices(java.util.List<ExclusiveModelCompleteServiceResponseBodyChoices> choices) {
        this.choices = choices;
        return this;
    }
    public java.util.List<ExclusiveModelCompleteServiceResponseBodyChoices> getChoices() {
        return this.choices;
    }

    public ExclusiveModelCompleteServiceResponseBody setCreated(Integer created) {
        this.created = created;
        return this;
    }
    public Integer getCreated() {
        return this.created;
    }

    public ExclusiveModelCompleteServiceResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public ExclusiveModelCompleteServiceResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public ExclusiveModelCompleteServiceResponseBody setUsage(ExclusiveModelCompleteServiceResponseBodyUsage usage) {
        this.usage = usage;
        return this;
    }
    public ExclusiveModelCompleteServiceResponseBodyUsage getUsage() {
        return this.usage;
    }

    public static class ExclusiveModelCompleteServiceResponseBodyChoicesMessage extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("reasoning_content")
        public String reasoningContent;

        @NameInMap("role")
        public String role;

        public static ExclusiveModelCompleteServiceResponseBodyChoicesMessage build(java.util.Map<String, ?> map) throws Exception {
            ExclusiveModelCompleteServiceResponseBodyChoicesMessage self = new ExclusiveModelCompleteServiceResponseBodyChoicesMessage();
            return TeaModel.build(map, self);
        }

        public ExclusiveModelCompleteServiceResponseBodyChoicesMessage setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ExclusiveModelCompleteServiceResponseBodyChoicesMessage setReasoningContent(String reasoningContent) {
            this.reasoningContent = reasoningContent;
            return this;
        }
        public String getReasoningContent() {
            return this.reasoningContent;
        }

        public ExclusiveModelCompleteServiceResponseBodyChoicesMessage setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

    public static class ExclusiveModelCompleteServiceResponseBodyChoices extends TeaModel {
        @NameInMap("finishReason")
        public String finishReason;

        @NameInMap("message")
        public ExclusiveModelCompleteServiceResponseBodyChoicesMessage message;

        public static ExclusiveModelCompleteServiceResponseBodyChoices build(java.util.Map<String, ?> map) throws Exception {
            ExclusiveModelCompleteServiceResponseBodyChoices self = new ExclusiveModelCompleteServiceResponseBodyChoices();
            return TeaModel.build(map, self);
        }

        public ExclusiveModelCompleteServiceResponseBodyChoices setFinishReason(String finishReason) {
            this.finishReason = finishReason;
            return this;
        }
        public String getFinishReason() {
            return this.finishReason;
        }

        public ExclusiveModelCompleteServiceResponseBodyChoices setMessage(ExclusiveModelCompleteServiceResponseBodyChoicesMessage message) {
            this.message = message;
            return this;
        }
        public ExclusiveModelCompleteServiceResponseBodyChoicesMessage getMessage() {
            return this.message;
        }

    }

    public static class ExclusiveModelCompleteServiceResponseBodyUsage extends TeaModel {
        @NameInMap("input_tokens")
        public Integer inputTokens;

        @NameInMap("output_tokens")
        public Integer outputTokens;

        @NameInMap("total_tokens")
        public Integer totalTokens;

        public static ExclusiveModelCompleteServiceResponseBodyUsage build(java.util.Map<String, ?> map) throws Exception {
            ExclusiveModelCompleteServiceResponseBodyUsage self = new ExclusiveModelCompleteServiceResponseBodyUsage();
            return TeaModel.build(map, self);
        }

        public ExclusiveModelCompleteServiceResponseBodyUsage setInputTokens(Integer inputTokens) {
            this.inputTokens = inputTokens;
            return this;
        }
        public Integer getInputTokens() {
            return this.inputTokens;
        }

        public ExclusiveModelCompleteServiceResponseBodyUsage setOutputTokens(Integer outputTokens) {
            this.outputTokens = outputTokens;
            return this;
        }
        public Integer getOutputTokens() {
            return this.outputTokens;
        }

        public ExclusiveModelCompleteServiceResponseBodyUsage setTotalTokens(Integer totalTokens) {
            this.totalTokens = totalTokens;
            return this;
        }
        public Integer getTotalTokens() {
            return this.totalTokens;
        }

    }

}
