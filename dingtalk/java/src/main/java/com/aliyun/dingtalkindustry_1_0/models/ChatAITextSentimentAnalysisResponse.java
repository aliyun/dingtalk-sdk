// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAITextSentimentAnalysisResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAITextSentimentAnalysisResponseBody body;

    public static ChatAITextSentimentAnalysisResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAITextSentimentAnalysisResponse self = new ChatAITextSentimentAnalysisResponse();
        return TeaModel.build(map, self);
    }

    public ChatAITextSentimentAnalysisResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAITextSentimentAnalysisResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAITextSentimentAnalysisResponse setBody(ChatAITextSentimentAnalysisResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAITextSentimentAnalysisResponseBody getBody() {
        return this.body;
    }

}
