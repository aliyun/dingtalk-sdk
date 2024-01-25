// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetIntellectualPropertyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetIntellectualPropertyResponseBody body;

    public static GetIntellectualPropertyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIntellectualPropertyResponse self = new GetIntellectualPropertyResponse();
        return TeaModel.build(map, self);
    }

    public GetIntellectualPropertyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIntellectualPropertyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetIntellectualPropertyResponse setBody(GetIntellectualPropertyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIntellectualPropertyResponseBody getBody() {
        return this.body;
    }

}
