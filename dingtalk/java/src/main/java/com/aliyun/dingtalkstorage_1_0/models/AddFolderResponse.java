// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddFolderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddFolderResponseBody body;

    public static AddFolderResponse build(java.util.Map<String, ?> map) throws Exception {
        AddFolderResponse self = new AddFolderResponse();
        return TeaModel.build(map, self);
    }

    public AddFolderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddFolderResponse setBody(AddFolderResponseBody body) {
        this.body = body;
        return this;
    }
    public AddFolderResponseBody getBody() {
        return this.body;
    }

}
