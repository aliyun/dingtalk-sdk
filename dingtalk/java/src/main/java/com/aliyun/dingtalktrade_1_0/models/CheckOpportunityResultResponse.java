// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CheckOpportunityResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CheckOpportunityResultResponseBody body;

    public static CheckOpportunityResultResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckOpportunityResultResponse self = new CheckOpportunityResultResponse();
        return TeaModel.build(map, self);
    }

    public CheckOpportunityResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckOpportunityResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckOpportunityResultResponse setBody(CheckOpportunityResultResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckOpportunityResultResponseBody getBody() {
        return this.body;
    }

}
