// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetHistoryConfDataListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetHistoryConfDataListResponseBody body;

    public static GetHistoryConfDataListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetHistoryConfDataListResponse self = new GetHistoryConfDataListResponse();
        return TeaModel.build(map, self);
    }

    public GetHistoryConfDataListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetHistoryConfDataListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetHistoryConfDataListResponse setBody(GetHistoryConfDataListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetHistoryConfDataListResponseBody getBody() {
        return this.body;
    }

}
