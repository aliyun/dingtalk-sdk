// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddLibraryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddLibraryResponseBody body;

    public static AddLibraryResponse build(java.util.Map<String, ?> map) throws Exception {
        AddLibraryResponse self = new AddLibraryResponse();
        return TeaModel.build(map, self);
    }

    public AddLibraryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddLibraryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddLibraryResponse setBody(AddLibraryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLibraryResponseBody getBody() {
        return this.body;
    }

}
