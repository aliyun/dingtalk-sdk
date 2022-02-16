// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryTemplateCategorysResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryTemplateCategorysResponseBody body;

    public static QueryTemplateCategorysResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTemplateCategorysResponse self = new QueryTemplateCategorysResponse();
        return TeaModel.build(map, self);
    }

    public QueryTemplateCategorysResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTemplateCategorysResponse setBody(QueryTemplateCategorysResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTemplateCategorysResponseBody getBody() {
        return this.body;
    }

}
