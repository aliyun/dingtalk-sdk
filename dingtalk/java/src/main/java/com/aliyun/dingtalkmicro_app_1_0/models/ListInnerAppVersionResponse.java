// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListInnerAppVersionResponseBody body;

    public static ListInnerAppVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        ListInnerAppVersionResponse self = new ListInnerAppVersionResponse();
        return TeaModel.build(map, self);
    }

    public ListInnerAppVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListInnerAppVersionResponse setBody(ListInnerAppVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public ListInnerAppVersionResponseBody getBody() {
        return this.body;
    }

}
