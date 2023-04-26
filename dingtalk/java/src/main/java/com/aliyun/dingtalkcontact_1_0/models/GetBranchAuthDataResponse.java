// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetBranchAuthDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetBranchAuthDataResponseBody body;

    public static GetBranchAuthDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBranchAuthDataResponse self = new GetBranchAuthDataResponse();
        return TeaModel.build(map, self);
    }

    public GetBranchAuthDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBranchAuthDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBranchAuthDataResponse setBody(GetBranchAuthDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBranchAuthDataResponseBody getBody() {
        return this.body;
    }

}
