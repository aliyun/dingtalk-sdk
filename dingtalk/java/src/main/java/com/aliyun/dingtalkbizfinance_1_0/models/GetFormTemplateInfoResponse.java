// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFormTemplateInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFormTemplateInfoResponseBody body;

    public static GetFormTemplateInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFormTemplateInfoResponse self = new GetFormTemplateInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetFormTemplateInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFormTemplateInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFormTemplateInfoResponse setBody(GetFormTemplateInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFormTemplateInfoResponseBody getBody() {
        return this.body;
    }

}
