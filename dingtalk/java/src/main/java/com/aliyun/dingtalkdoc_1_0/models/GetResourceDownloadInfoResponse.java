// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetResourceDownloadInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetResourceDownloadInfoResponseBody body;

    public static GetResourceDownloadInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResourceDownloadInfoResponse self = new GetResourceDownloadInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResourceDownloadInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResourceDownloadInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResourceDownloadInfoResponse setBody(GetResourceDownloadInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResourceDownloadInfoResponseBody getBody() {
        return this.body;
    }

}
