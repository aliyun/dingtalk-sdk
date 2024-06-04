// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDocContentForELMResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDocContentForELMResponseBody body;

    public static GetDocContentForELMResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDocContentForELMResponse self = new GetDocContentForELMResponse();
        return TeaModel.build(map, self);
    }

    public GetDocContentForELMResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDocContentForELMResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDocContentForELMResponse setBody(GetDocContentForELMResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDocContentForELMResponseBody getBody() {
        return this.body;
    }

}
