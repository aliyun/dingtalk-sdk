// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetSpaceWithDownloadAuthResponse setBody(GetSpaceWithDownloadAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpaceWithDownloadAuthResponseBody getBody() {
        return this.body;
    }

}
