// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class GetAiTaskResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAiTaskResultResponseBody body;

    public static GetAiTaskResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAiTaskResultResponse self = new GetAiTaskResultResponse();
        return TeaModel.build(map, self);
    }

    public GetAiTaskResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAiTaskResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAiTaskResultResponse setBody(GetAiTaskResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAiTaskResultResponseBody getBody() {
        return this.body;
    }

}
