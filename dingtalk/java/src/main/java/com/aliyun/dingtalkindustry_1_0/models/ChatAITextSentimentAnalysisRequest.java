// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAITextSentimentAnalysisRequest extends TeaModel {
    @NameInMap("history")
    public java.util.List<String> history;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("text")
    public String text;

    public static ChatAITextSentimentAnalysisRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAITextSentimentAnalysisRequest self = new ChatAITextSentimentAnalysisRequest();
        return TeaModel.build(map, self);
    }

    public ChatAITextSentimentAnalysisRequest setHistory(java.util.List<String> history) {
        this.history = history;
        return this;
    }
    public java.util.List<String> getHistory() {
        return this.history;
    }

    public ChatAITextSentimentAnalysisRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

}
