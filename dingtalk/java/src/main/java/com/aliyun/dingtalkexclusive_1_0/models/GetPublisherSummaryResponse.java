// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublisherSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetPublisherSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPublisherSummaryResponse setBody(GetPublisherSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPublisherSummaryResponseBody getBody() {
        return this.body;
    }

}
