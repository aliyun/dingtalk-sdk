// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class GetUploadTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUploadTokenResponseBody body;

    public static GetUploadTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUploadTokenResponse self = new GetUploadTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetUploadTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUploadTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUploadTokenResponse setBody(GetUploadTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUploadTokenResponseBody getBody() {
        return this.body;
    }

}
