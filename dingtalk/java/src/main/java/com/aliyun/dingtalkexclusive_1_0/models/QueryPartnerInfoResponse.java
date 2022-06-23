// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryPartnerInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPartnerInfoResponseBody body;

    public static QueryPartnerInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPartnerInfoResponse self = new QueryPartnerInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryPartnerInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPartnerInfoResponse setBody(QueryPartnerInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPartnerInfoResponseBody getBody() {
        return this.body;
    }

}
