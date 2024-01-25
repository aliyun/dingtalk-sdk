// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class PagePointHistoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PagePointHistoryResponseBody body;

    public static PagePointHistoryResponse build(java.util.Map<String, ?> map) throws Exception {
        PagePointHistoryResponse self = new PagePointHistoryResponse();
        return TeaModel.build(map, self);
    }

    public PagePointHistoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PagePointHistoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PagePointHistoryResponse setBody(PagePointHistoryResponseBody body) {
        this.body = body;
        return this;
    }
    public PagePointHistoryResponseBody getBody() {
        return this.body;
    }

}
