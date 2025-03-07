// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveModelCompleteServiceRequest extends TeaModel {
    @NameInMap("enable_search")
    public Boolean enableSearch;

    @NameInMap("max_tokens")
    public Integer maxTokens;

    @NameInMap("messages")
    public java.util.List<ExclusiveModelCompleteServiceRequestMessages> messages;

    @NameInMap("model")
    public String model;

    @NameInMap("temperature")
    public Double temperature;

    @NameInMap("top_p")
    public Double topP;

    public static ExclusiveModelCompleteServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveModelCompleteServiceRequest self = new ExclusiveModelCompleteServiceRequest();
        return TeaModel.build(map, self);
    }

    public ExclusiveModelCompleteServiceRequest setEnableSearch(Boolean enableSearch) {
        this.enableSearch = enableSearch;
        return this;
    }
    public Boolean getEnableSearch() {
        return this.enableSearch;
    }

    public ExclusiveModelCompleteServiceRequest setMaxTokens(Integer maxTokens) {
        this.maxTokens = maxTokens;
        return this;
    }
    public Integer getMaxTokens() {
        return this.maxTokens;
    }

    public ExclusiveModelCompleteServiceRequest setMessages(java.util.List<ExclusiveModelCompleteServiceRequestMessages> messages) {
        this.messages = messages;
        return this;
    }
    public java.util.List<ExclusiveModelCompleteServiceRequestMessages> getMessages() {
        return this.messages;
    }

    public ExclusiveModelCompleteServiceRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public ExclusiveModelCompleteServiceRequest setTemperature(Double temperature) {
        this.temperature = temperature;
        return this;
    }
    public Double getTemperature() {
        return this.temperature;
    }

    public ExclusiveModelCompleteServiceRequest setTopP(Double topP) {
        this.topP = topP;
        return this;
    }
    public Double getTopP() {
        return this.topP;
    }

    public static class ExclusiveModelCompleteServiceRequestMessages extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("role")
        public String role;

        public static ExclusiveModelCompleteServiceRequestMessages build(java.util.Map<String, ?> map) throws Exception {
            ExclusiveModelCompleteServiceRequestMessages self = new ExclusiveModelCompleteServiceRequestMessages();
            return TeaModel.build(map, self);
        }

        public ExclusiveModelCompleteServiceRequestMessages setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ExclusiveModelCompleteServiceRequestMessages setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

}
