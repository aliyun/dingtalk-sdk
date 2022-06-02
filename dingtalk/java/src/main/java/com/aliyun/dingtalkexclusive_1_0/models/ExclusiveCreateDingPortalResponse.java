// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveCreateDingPortalResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ExclusiveCreateDingPortalResponseBody body;

    public static ExclusiveCreateDingPortalResponse build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveCreateDingPortalResponse self = new ExclusiveCreateDingPortalResponse();
        return TeaModel.build(map, self);
    }

    public ExclusiveCreateDingPortalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExclusiveCreateDingPortalResponse setBody(ExclusiveCreateDingPortalResponseBody body) {
        this.body = body;
        return this;
    }
    public ExclusiveCreateDingPortalResponseBody getBody() {
        return this.body;
    }

}
