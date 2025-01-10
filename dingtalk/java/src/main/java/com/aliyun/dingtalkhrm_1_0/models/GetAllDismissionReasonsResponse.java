// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetAllDismissionReasonsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAllDismissionReasonsResponseBody body;

    public static GetAllDismissionReasonsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllDismissionReasonsResponse self = new GetAllDismissionReasonsResponse();
        return TeaModel.build(map, self);
    }

    public GetAllDismissionReasonsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllDismissionReasonsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllDismissionReasonsResponse setBody(GetAllDismissionReasonsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllDismissionReasonsResponseBody getBody() {
        return this.body;
    }

}
