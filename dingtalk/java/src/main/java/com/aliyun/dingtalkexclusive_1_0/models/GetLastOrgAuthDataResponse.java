// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetLastOrgAuthDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetLastOrgAuthDataResponseBody body;

    public static GetLastOrgAuthDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLastOrgAuthDataResponse self = new GetLastOrgAuthDataResponse();
        return TeaModel.build(map, self);
    }

    public GetLastOrgAuthDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetLastOrgAuthDataResponse setBody(GetLastOrgAuthDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLastOrgAuthDataResponseBody getBody() {
        return this.body;
    }

}
