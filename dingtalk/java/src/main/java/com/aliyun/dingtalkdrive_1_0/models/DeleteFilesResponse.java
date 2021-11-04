// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteFilesResponseBody body;

    public static DeleteFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilesResponse self = new DeleteFilesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteFilesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteFilesResponse setBody(DeleteFilesResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteFilesResponseBody getBody() {
        return this.body;
    }

}
