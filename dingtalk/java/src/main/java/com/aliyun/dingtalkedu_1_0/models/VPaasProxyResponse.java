// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VPaasProxyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public VPaasProxyResponseBody body;

    public static VPaasProxyResponse build(java.util.Map<String, ?> map) throws Exception {
        VPaasProxyResponse self = new VPaasProxyResponse();
        return TeaModel.build(map, self);
    }

    public VPaasProxyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public VPaasProxyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public VPaasProxyResponse setBody(VPaasProxyResponseBody body) {
        this.body = body;
        return this;
    }
    public VPaasProxyResponseBody getBody() {
        return this.body;
    }

}
