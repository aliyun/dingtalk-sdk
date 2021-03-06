// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomEntryProcessesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCustomEntryProcessesResponseBody body;

    public static QueryCustomEntryProcessesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomEntryProcessesResponse self = new QueryCustomEntryProcessesResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomEntryProcessesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomEntryProcessesResponse setBody(QueryCustomEntryProcessesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomEntryProcessesResponseBody getBody() {
        return this.body;
    }

}
