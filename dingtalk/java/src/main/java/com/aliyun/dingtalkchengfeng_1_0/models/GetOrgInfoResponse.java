// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetOrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOrgInfoResponseBody body;

    public static GetOrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgInfoResponse self = new GetOrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrgInfoResponse setBody(GetOrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgInfoResponseBody getBody() {
        return this.body;
    }

}
