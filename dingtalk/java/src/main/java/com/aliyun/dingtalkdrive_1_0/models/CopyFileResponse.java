// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class CopyFileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CopyFileResponseBody body;

    public static CopyFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyFileResponse self = new CopyFileResponse();
        return TeaModel.build(map, self);
    }

    public CopyFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyFileResponse setBody(CopyFileResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyFileResponseBody getBody() {
        return this.body;
    }

}
