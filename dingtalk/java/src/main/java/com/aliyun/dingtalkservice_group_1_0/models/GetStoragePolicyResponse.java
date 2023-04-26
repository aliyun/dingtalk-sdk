// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetStoragePolicyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetStoragePolicyResponseBody body;

    public static GetStoragePolicyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetStoragePolicyResponse self = new GetStoragePolicyResponse();
        return TeaModel.build(map, self);
    }

    public GetStoragePolicyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetStoragePolicyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetStoragePolicyResponse setBody(GetStoragePolicyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetStoragePolicyResponseBody getBody() {
        return this.body;
    }

}
