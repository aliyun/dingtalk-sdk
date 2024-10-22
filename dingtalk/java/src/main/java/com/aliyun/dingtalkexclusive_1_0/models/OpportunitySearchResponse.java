// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class OpportunitySearchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpportunitySearchResponseBody body;

    public static OpportunitySearchResponse build(java.util.Map<String, ?> map) throws Exception {
        OpportunitySearchResponse self = new OpportunitySearchResponse();
        return TeaModel.build(map, self);
    }

    public OpportunitySearchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpportunitySearchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpportunitySearchResponse setBody(OpportunitySearchResponseBody body) {
        this.body = body;
        return this;
    }
    public OpportunitySearchResponseBody getBody() {
        return this.body;
    }

}
