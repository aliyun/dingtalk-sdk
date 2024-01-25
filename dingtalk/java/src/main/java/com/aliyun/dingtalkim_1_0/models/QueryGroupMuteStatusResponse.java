// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMuteStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryGroupMuteStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupMuteStatusResponse setBody(QueryGroupMuteStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMuteStatusResponseBody getBody() {
        return this.body;
    }

}
