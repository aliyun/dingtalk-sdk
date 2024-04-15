// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetFieldModifiedHistoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFieldModifiedHistoryResponseBody body;

    public static GetFieldModifiedHistoryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFieldModifiedHistoryResponse self = new GetFieldModifiedHistoryResponse();
        return TeaModel.build(map, self);
    }

    public GetFieldModifiedHistoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFieldModifiedHistoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFieldModifiedHistoryResponse setBody(GetFieldModifiedHistoryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFieldModifiedHistoryResponseBody getBody() {
        return this.body;
    }

}
