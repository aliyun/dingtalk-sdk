// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryReceiptsByPageResponseBody body;

    public static QueryReceiptsByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsByPageResponse self = new QueryReceiptsByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryReceiptsByPageResponse setBody(QueryReceiptsByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptsByPageResponseBody getBody() {
        return this.body;
    }

}
