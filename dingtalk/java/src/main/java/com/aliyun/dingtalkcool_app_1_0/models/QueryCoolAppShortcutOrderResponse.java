// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class QueryCoolAppShortcutOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCoolAppShortcutOrderResponseBody body;

    public static QueryCoolAppShortcutOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCoolAppShortcutOrderResponse self = new QueryCoolAppShortcutOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryCoolAppShortcutOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCoolAppShortcutOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCoolAppShortcutOrderResponse setBody(QueryCoolAppShortcutOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCoolAppShortcutOrderResponseBody getBody() {
        return this.body;
    }

}
