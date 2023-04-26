// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateByIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetTemplateByIdResponseBody body;

    public static GetTemplateByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTemplateByIdResponse self = new GetTemplateByIdResponse();
        return TeaModel.build(map, self);
    }

    public GetTemplateByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTemplateByIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTemplateByIdResponse setBody(GetTemplateByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTemplateByIdResponseBody getBody() {
        return this.body;
    }

}
