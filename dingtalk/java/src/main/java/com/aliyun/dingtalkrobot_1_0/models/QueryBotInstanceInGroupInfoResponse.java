// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryBotInstanceInGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryBotInstanceInGroupInfoResponseBody body;

    public static QueryBotInstanceInGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBotInstanceInGroupInfoResponse self = new QueryBotInstanceInGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryBotInstanceInGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBotInstanceInGroupInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBotInstanceInGroupInfoResponse setBody(QueryBotInstanceInGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBotInstanceInGroupInfoResponseBody getBody() {
        return this.body;
    }

}
