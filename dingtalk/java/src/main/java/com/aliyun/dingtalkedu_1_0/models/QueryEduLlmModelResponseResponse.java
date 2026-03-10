// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduLlmModelResponseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryEduLlmModelResponseResponseBody body;

    public static QueryEduLlmModelResponseResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEduLlmModelResponseResponse self = new QueryEduLlmModelResponseResponse();
        return TeaModel.build(map, self);
    }

    public QueryEduLlmModelResponseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEduLlmModelResponseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryEduLlmModelResponseResponse setBody(QueryEduLlmModelResponseResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEduLlmModelResponseResponseBody getBody() {
        return this.body;
    }

}
