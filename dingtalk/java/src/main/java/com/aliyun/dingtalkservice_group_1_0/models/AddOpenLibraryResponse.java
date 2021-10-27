// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenLibraryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddOpenLibraryResponse setBody(AddOpenLibraryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOpenLibraryResponseBody getBody() {
        return this.body;
    }

}
