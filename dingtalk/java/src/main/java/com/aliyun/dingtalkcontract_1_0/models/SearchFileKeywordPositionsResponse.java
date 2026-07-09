// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SearchFileKeywordPositionsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchFileKeywordPositionsResponseBody body;

    public static SearchFileKeywordPositionsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchFileKeywordPositionsResponse self = new SearchFileKeywordPositionsResponse();
        return TeaModel.build(map, self);
    }

    public SearchFileKeywordPositionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchFileKeywordPositionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchFileKeywordPositionsResponse setBody(SearchFileKeywordPositionsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchFileKeywordPositionsResponseBody getBody() {
        return this.body;
    }

}
