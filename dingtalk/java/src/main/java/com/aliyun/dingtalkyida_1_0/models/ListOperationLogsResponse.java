// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListOperationLogsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListOperationLogsResponseBody body;

    public static ListOperationLogsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListOperationLogsResponse self = new ListOperationLogsResponse();
        return TeaModel.build(map, self);
    }

    public ListOperationLogsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListOperationLogsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListOperationLogsResponse setBody(ListOperationLogsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOperationLogsResponseBody getBody() {
        return this.body;
    }

}
