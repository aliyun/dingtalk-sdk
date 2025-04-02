// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateWrongQuestionsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateWrongQuestionsResponseBody body;

    public static CreateWrongQuestionsResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateWrongQuestionsResponse self = new CreateWrongQuestionsResponse();
        return TeaModel.build(map, self);
    }

    public CreateWrongQuestionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateWrongQuestionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateWrongQuestionsResponse setBody(CreateWrongQuestionsResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateWrongQuestionsResponseBody getBody() {
        return this.body;
    }

}
