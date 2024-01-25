// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class SearchCompanyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchCompanyResponseBody body;

    public static SearchCompanyResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchCompanyResponse self = new SearchCompanyResponse();
        return TeaModel.build(map, self);
    }

    public SearchCompanyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchCompanyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchCompanyResponse setBody(SearchCompanyResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchCompanyResponseBody getBody() {
        return this.body;
    }

}
