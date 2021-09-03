// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDocCreatedSummaryResponseBody body;

    public static GetDocCreatedSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedSummaryResponse self = new GetDocCreatedSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDocCreatedSummaryResponse setBody(GetDocCreatedSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDocCreatedSummaryResponseBody getBody() {
        return this.body;
    }

}
