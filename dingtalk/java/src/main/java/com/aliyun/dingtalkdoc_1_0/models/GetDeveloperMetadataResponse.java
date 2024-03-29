// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetDeveloperMetadataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDeveloperMetadataResponseBody body;

    public static GetDeveloperMetadataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeveloperMetadataResponse self = new GetDeveloperMetadataResponse();
        return TeaModel.build(map, self);
    }

    public GetDeveloperMetadataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeveloperMetadataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDeveloperMetadataResponse setBody(GetDeveloperMetadataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeveloperMetadataResponseBody getBody() {
        return this.body;
    }

}
