// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryChatAIOXMInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryChatAIOXMInfoResponseBody body;

    public static QueryChatAIOXMInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryChatAIOXMInfoResponse self = new QueryChatAIOXMInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryChatAIOXMInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryChatAIOXMInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryChatAIOXMInfoResponse setBody(QueryChatAIOXMInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryChatAIOXMInfoResponseBody getBody() {
        return this.body;
    }

}
