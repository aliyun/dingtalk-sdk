// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetSpaceWithDownloadAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetSpaceWithDownloadAuthResponseBody body;

    public static PremiumGetSpaceWithDownloadAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetSpaceWithDownloadAuthResponse self = new PremiumGetSpaceWithDownloadAuthResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetSpaceWithDownloadAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetSpaceWithDownloadAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetSpaceWithDownloadAuthResponse setBody(PremiumGetSpaceWithDownloadAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetSpaceWithDownloadAuthResponseBody getBody() {
        return this.body;
    }

}
