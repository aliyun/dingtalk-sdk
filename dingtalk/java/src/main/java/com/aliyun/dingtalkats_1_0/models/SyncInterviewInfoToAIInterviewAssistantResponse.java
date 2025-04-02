// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SyncInterviewInfoToAIInterviewAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncInterviewInfoToAIInterviewAssistantResponseBody body;

    public static SyncInterviewInfoToAIInterviewAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncInterviewInfoToAIInterviewAssistantResponse self = new SyncInterviewInfoToAIInterviewAssistantResponse();
        return TeaModel.build(map, self);
    }

    public SyncInterviewInfoToAIInterviewAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncInterviewInfoToAIInterviewAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncInterviewInfoToAIInterviewAssistantResponse setBody(SyncInterviewInfoToAIInterviewAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncInterviewInfoToAIInterviewAssistantResponseBody getBody() {
        return this.body;
    }

}
