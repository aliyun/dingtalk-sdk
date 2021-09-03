// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetActiveUserSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetActiveUserSummaryResponseBody body;

    public static GetActiveUserSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetActiveUserSummaryResponse self = new GetActiveUserSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetActiveUserSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetActiveUserSummaryResponse setBody(GetActiveUserSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetActiveUserSummaryResponseBody getBody() {
        return this.body;
    }

}
