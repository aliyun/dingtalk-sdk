// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SortFilterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SortFilterResponseBody body;

    public static SortFilterResponse build(java.util.Map<String, ?> map) throws Exception {
        SortFilterResponse self = new SortFilterResponse();
        return TeaModel.build(map, self);
    }

    public SortFilterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SortFilterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SortFilterResponse setBody(SortFilterResponseBody body) {
        this.body = body;
        return this;
    }
    public SortFilterResponseBody getBody() {
        return this.body;
    }

}
