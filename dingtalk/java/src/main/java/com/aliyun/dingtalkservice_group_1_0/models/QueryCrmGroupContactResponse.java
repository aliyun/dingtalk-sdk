// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupContactResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCrmGroupContactResponseBody body;

    public static QueryCrmGroupContactResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupContactResponse self = new QueryCrmGroupContactResponse();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupContactResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCrmGroupContactResponse setBody(QueryCrmGroupContactResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCrmGroupContactResponseBody getBody() {
        return this.body;
    }

}
