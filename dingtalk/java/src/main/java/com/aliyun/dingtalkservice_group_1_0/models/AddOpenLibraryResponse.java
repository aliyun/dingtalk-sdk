// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenLibraryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddOpenLibraryResponseBody body;

    public static AddOpenLibraryResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOpenLibraryResponse self = new AddOpenLibraryResponse();
        return TeaModel.build(map, self);
    }

    public AddOpenLibraryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOpenLibraryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddOpenLibraryResponse setBody(AddOpenLibraryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOpenLibraryResponseBody getBody() {
        return this.body;
    }

}
