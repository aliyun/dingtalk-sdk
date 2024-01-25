// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOrganizationsResponseBody body;

    public static GetOrganizationsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationsResponse self = new GetOrganizationsResponse();
        return TeaModel.build(map, self);
    }

    public GetOrganizationsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrganizationsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrganizationsResponse setBody(GetOrganizationsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizationsResponseBody getBody() {
        return this.body;
    }

}
