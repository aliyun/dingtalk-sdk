// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrgInfoResponseBody body;

    public static OrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        OrgInfoResponse self = new OrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public OrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrgInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrgInfoResponse setBody(OrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public OrgInfoResponseBody getBody() {
        return this.body;
    }

}
