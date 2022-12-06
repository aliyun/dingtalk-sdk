// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertDropdownListsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public InsertDropdownListsResponse setBody(InsertDropdownListsResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertDropdownListsResponseBody getBody() {
        return this.body;
    }

}
