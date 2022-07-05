// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RenameDentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DentryVO body;

    public static RenameDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        RenameDentryResponse self = new RenameDentryResponse();
        return TeaModel.build(map, self);
    }

    public RenameDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RenameDentryResponse setBody(DentryVO body) {
        this.body = body;
        return this;
    }
    public DentryVO getBody() {
        return this.body;
    }

}
