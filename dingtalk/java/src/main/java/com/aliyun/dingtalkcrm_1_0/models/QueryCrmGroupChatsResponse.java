// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupChatsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCrmGroupChatsResponseBody body;

    public static QueryCrmGroupChatsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupChatsResponse self = new QueryCrmGroupChatsResponse();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupChatsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCrmGroupChatsResponse setBody(QueryCrmGroupChatsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCrmGroupChatsResponseBody getBody() {
        return this.body;
    }

}
