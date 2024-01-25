// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchDepartmentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchDepartmentResponseBody body;

    public static SearchDepartmentResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchDepartmentResponse self = new SearchDepartmentResponse();
        return TeaModel.build(map, self);
    }

    public SearchDepartmentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchDepartmentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchDepartmentResponse setBody(SearchDepartmentResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchDepartmentResponseBody getBody() {
        return this.body;
    }

}
