// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteDropdownListsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteDropdownListsResponseBody body;

    public static DeleteDropdownListsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDropdownListsResponse self = new DeleteDropdownListsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDropdownListsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDropdownListsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDropdownListsResponse setBody(DeleteDropdownListsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDropdownListsResponseBody getBody() {
        return this.body;
    }

}
