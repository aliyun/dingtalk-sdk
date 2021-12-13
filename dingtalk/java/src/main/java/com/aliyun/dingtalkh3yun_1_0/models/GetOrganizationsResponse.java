// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetOrganizationsResponse setBody(GetOrganizationsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizationsResponseBody getBody() {
        return this.body;
    }

}
