// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertDropdownListsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InsertDropdownListsResponseBody body;

    public static InsertDropdownListsResponse build(java.util.Map<String, ?> map) throws Exception {
        InsertDropdownListsResponse self = new InsertDropdownListsResponse();
        return TeaModel.build(map, self);
    }

    public InsertDropdownListsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InsertDropdownListsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InsertDropdownListsResponse setBody(InsertDropdownListsResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertDropdownListsResponseBody getBody() {
        return this.body;
    }

}
