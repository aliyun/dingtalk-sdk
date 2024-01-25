// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSpaceWithDownloadAuthResponseBody body;

    public static GetSpaceWithDownloadAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceWithDownloadAuthResponse self = new GetSpaceWithDownloadAuthResponse();
        return TeaModel.build(map, self);
    }

    public GetSpaceWithDownloadAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSpaceWithDownloadAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSpaceWithDownloadAuthResponse setBody(GetSpaceWithDownloadAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpaceWithDownloadAuthResponseBody getBody() {
        return this.body;
    }

}
