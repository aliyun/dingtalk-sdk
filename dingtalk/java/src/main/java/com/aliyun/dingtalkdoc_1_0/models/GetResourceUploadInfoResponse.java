// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUploadInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetResourceUploadInfoResponseBody body;

    public static GetResourceUploadInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUploadInfoResponse self = new GetResourceUploadInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResourceUploadInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResourceUploadInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResourceUploadInfoResponse setBody(GetResourceUploadInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResourceUploadInfoResponseBody getBody() {
        return this.body;
    }

}
