// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaByProcessCodeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySchemaByProcessCodeResponseBody body;

    public static QuerySchemaByProcessCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaByProcessCodeResponse self = new QuerySchemaByProcessCodeResponse();
        return TeaModel.build(map, self);
    }

    public QuerySchemaByProcessCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySchemaByProcessCodeResponse setBody(QuerySchemaByProcessCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySchemaByProcessCodeResponseBody getBody() {
        return this.body;
    }

}