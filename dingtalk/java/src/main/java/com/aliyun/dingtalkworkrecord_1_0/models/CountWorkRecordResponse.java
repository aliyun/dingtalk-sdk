// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkrecord_1_0.models;

import com.aliyun.tea.*;

public class CountWorkRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CountWorkRecordResponseBody body;

    public static CountWorkRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        CountWorkRecordResponse self = new CountWorkRecordResponse();
        return TeaModel.build(map, self);
    }

    public CountWorkRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CountWorkRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CountWorkRecordResponse setBody(CountWorkRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public CountWorkRecordResponseBody getBody() {
        return this.body;
    }

}
