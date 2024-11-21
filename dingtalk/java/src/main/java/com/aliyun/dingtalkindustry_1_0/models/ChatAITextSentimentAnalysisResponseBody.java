// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAITextSentimentAnalysisResponseBody extends TeaModel {
    @NameInMap("result")
    public ChatAITextSentimentAnalysisResponseBodyResult result;

    public static ChatAITextSentimentAnalysisResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAITextSentimentAnalysisResponseBody self = new ChatAITextSentimentAnalysisResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAITextSentimentAnalysisResponseBody setResult(ChatAITextSentimentAnalysisResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ChatAITextSentimentAnalysisResponseBodyResult getResult() {
        return this.result;
    }

    public static class ChatAITextSentimentAnalysisResponseBodyResult extends TeaModel {
        @NameInMap("sentiment")
        public String sentiment;

        public static ChatAITextSentimentAnalysisResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ChatAITextSentimentAnalysisResponseBodyResult self = new ChatAITextSentimentAnalysisResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ChatAITextSentimentAnalysisResponseBodyResult setSentiment(String sentiment) {
            this.sentiment = sentiment;
            return this;
        }
        public String getSentiment() {
            return this.sentiment;
        }

    }

}
