// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFileDownloadUrlResponseBody body;

    public static GetFileDownloadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadUrlResponse self = new GetFileDownloadUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFileDownloadUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFileDownloadUrlResponse setBody(GetFileDownloadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFileDownloadUrlResponseBody getBody() {
        return this.body;
    }

}
