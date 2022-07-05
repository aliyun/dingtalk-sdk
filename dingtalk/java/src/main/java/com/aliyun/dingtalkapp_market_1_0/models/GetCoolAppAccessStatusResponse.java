// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetCoolAppAccessStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCoolAppAccessStatusResponseBody body;

    public static GetCoolAppAccessStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCoolAppAccessStatusResponse self = new GetCoolAppAccessStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetCoolAppAccessStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCoolAppAccessStatusResponse setBody(GetCoolAppAccessStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCoolAppAccessStatusResponseBody getBody() {
        return this.body;
    }

}
