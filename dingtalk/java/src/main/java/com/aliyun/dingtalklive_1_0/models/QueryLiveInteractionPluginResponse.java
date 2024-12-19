// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveInteractionPluginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryLiveInteractionPluginResponseBody body;

    public static QueryLiveInteractionPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveInteractionPluginResponse self = new QueryLiveInteractionPluginResponse();
        return TeaModel.build(map, self);
    }

    public QueryLiveInteractionPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryLiveInteractionPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryLiveInteractionPluginResponse setBody(QueryLiveInteractionPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryLiveInteractionPluginResponseBody getBody() {
        return this.body;
    }

}
