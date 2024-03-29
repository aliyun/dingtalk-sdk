// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryOpportunityTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryOpportunityTagResponseBody body;

    public static BatchQueryOpportunityTagResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOpportunityTagResponse self = new BatchQueryOpportunityTagResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryOpportunityTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryOpportunityTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryOpportunityTagResponse setBody(BatchQueryOpportunityTagResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryOpportunityTagResponseBody getBody() {
        return this.body;
    }

}
