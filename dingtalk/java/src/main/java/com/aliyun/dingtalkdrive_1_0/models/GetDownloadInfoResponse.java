// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDownloadInfoResponseBody body;

    public static GetDownloadInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadInfoResponse self = new GetDownloadInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetDownloadInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDownloadInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDownloadInfoResponse setBody(GetDownloadInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDownloadInfoResponseBody getBody() {
        return this.body;
    }

}
