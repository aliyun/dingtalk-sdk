// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublisherSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetPublisherSummaryResponseBody body;

    public static GetPublisherSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPublisherSummaryResponse self = new GetPublisherSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetPublisherSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPublisherSummaryResponse setBody(GetPublisherSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPublisherSummaryResponseBody getBody() {
        return this.body;
    }

}
