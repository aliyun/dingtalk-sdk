// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetHandSignDownloadUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetHandSignDownloadUrlResponseBody body;

    public static GetHandSignDownloadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetHandSignDownloadUrlResponse self = new GetHandSignDownloadUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetHandSignDownloadUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetHandSignDownloadUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetHandSignDownloadUrlResponse setBody(GetHandSignDownloadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetHandSignDownloadUrlResponseBody getBody() {
        return this.body;
    }

}
