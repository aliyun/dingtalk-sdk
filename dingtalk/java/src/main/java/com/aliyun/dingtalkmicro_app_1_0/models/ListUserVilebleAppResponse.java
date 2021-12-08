// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListUserVilebleAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserVilebleAppResponseBody body;

    public static ListUserVilebleAppResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUserVilebleAppResponse self = new ListUserVilebleAppResponse();
        return TeaModel.build(map, self);
    }

    public ListUserVilebleAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListUserVilebleAppResponse setBody(ListUserVilebleAppResponseBody body) {
        this.body = body;
        return this;
    }
    public ListUserVilebleAppResponseBody getBody() {
        return this.body;
    }

}
