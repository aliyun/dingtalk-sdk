// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMuteStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupMuteStatusResponseBody body;

    public static QueryGroupMuteStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMuteStatusResponse self = new QueryGroupMuteStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupMuteStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupMuteStatusResponse setBody(QueryGroupMuteStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMuteStatusResponseBody getBody() {
        return this.body;
    }

}
