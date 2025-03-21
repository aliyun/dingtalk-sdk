// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduAIModelCompleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EduAIModelCompleteResponseBody body;

    public static EduAIModelCompleteResponse build(java.util.Map<String, ?> map) throws Exception {
        EduAIModelCompleteResponse self = new EduAIModelCompleteResponse();
        return TeaModel.build(map, self);
    }

    public EduAIModelCompleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EduAIModelCompleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EduAIModelCompleteResponse setBody(EduAIModelCompleteResponseBody body) {
        this.body = body;
        return this;
    }
    public EduAIModelCompleteResponseBody getBody() {
        return this.body;
    }

}
