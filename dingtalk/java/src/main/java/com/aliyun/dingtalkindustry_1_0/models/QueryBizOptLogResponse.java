// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryBizOptLogResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryBizOptLogResponseBody body;

    public static QueryBizOptLogResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBizOptLogResponse self = new QueryBizOptLogResponse();
        return TeaModel.build(map, self);
    }

    public QueryBizOptLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBizOptLogResponse setBody(QueryBizOptLogResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBizOptLogResponseBody getBody() {
        return this.body;
    }

}
