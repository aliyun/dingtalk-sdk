// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduAIGCCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EduAIGCCallbackResponseBody body;

    public static EduAIGCCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        EduAIGCCallbackResponse self = new EduAIGCCallbackResponse();
        return TeaModel.build(map, self);
    }

    public EduAIGCCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EduAIGCCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EduAIGCCallbackResponse setBody(EduAIGCCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public EduAIGCCallbackResponseBody getBody() {
        return this.body;
    }

}
