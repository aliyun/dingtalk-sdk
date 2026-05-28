// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetPublishAuditResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPublishAuditResponseBody body;

    public static GetPublishAuditResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPublishAuditResponse self = new GetPublishAuditResponse();
        return TeaModel.build(map, self);
    }

    public GetPublishAuditResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPublishAuditResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPublishAuditResponse setBody(GetPublishAuditResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPublishAuditResponseBody getBody() {
        return this.body;
    }

}
