// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetIsNewVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetIsNewVersionResponseBody body;

    public static GetIsNewVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIsNewVersionResponse self = new GetIsNewVersionResponse();
        return TeaModel.build(map, self);
    }

    public GetIsNewVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIsNewVersionResponse setBody(GetIsNewVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIsNewVersionResponseBody getBody() {
        return this.body;
    }

}