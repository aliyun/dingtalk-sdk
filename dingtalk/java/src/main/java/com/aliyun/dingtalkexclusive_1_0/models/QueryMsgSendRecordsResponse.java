// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryMsgSendRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMsgSendRecordsResponseBody body;

    public static QueryMsgSendRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMsgSendRecordsResponse self = new QueryMsgSendRecordsResponse();
        return TeaModel.build(map, self);
    }

    public QueryMsgSendRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMsgSendRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMsgSendRecordsResponse setBody(QueryMsgSendRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMsgSendRecordsResponseBody getBody() {
        return this.body;
    }

}
