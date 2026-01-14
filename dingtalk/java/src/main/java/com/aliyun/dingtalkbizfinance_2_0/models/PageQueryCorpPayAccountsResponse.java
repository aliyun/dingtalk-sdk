// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class PageQueryCorpPayAccountsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageQueryCorpPayAccountsResponseBody body;

    public static PageQueryCorpPayAccountsResponse build(java.util.Map<String, ?> map) throws Exception {
        PageQueryCorpPayAccountsResponse self = new PageQueryCorpPayAccountsResponse();
        return TeaModel.build(map, self);
    }

    public PageQueryCorpPayAccountsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageQueryCorpPayAccountsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageQueryCorpPayAccountsResponse setBody(PageQueryCorpPayAccountsResponseBody body) {
        this.body = body;
        return this;
    }
    public PageQueryCorpPayAccountsResponseBody getBody() {
        return this.body;
    }

}
