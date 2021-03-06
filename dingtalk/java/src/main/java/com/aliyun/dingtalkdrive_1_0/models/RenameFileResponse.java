// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class RenameFileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RenameFileResponseBody body;

    public static RenameFileResponse build(java.util.Map<String, ?> map) throws Exception {
        RenameFileResponse self = new RenameFileResponse();
        return TeaModel.build(map, self);
    }

    public RenameFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RenameFileResponse setBody(RenameFileResponseBody body) {
        this.body = body;
        return this;
    }
    public RenameFileResponseBody getBody() {
        return this.body;
    }

}
