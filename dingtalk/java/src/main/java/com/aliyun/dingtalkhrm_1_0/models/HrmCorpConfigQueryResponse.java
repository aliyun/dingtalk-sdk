// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmCorpConfigQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmCorpConfigQueryResponseBody body;

    public static HrmCorpConfigQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmCorpConfigQueryResponse self = new HrmCorpConfigQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrmCorpConfigQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmCorpConfigQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmCorpConfigQueryResponse setBody(HrmCorpConfigQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmCorpConfigQueryResponseBody getBody() {
        return this.body;
    }

}
