// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SetRightPanelResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SetRightPanelResponseBody body;

    public static SetRightPanelResponse build(java.util.Map<String, ?> map) throws Exception {
        SetRightPanelResponse self = new SetRightPanelResponse();
        return TeaModel.build(map, self);
    }

    public SetRightPanelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetRightPanelResponse setBody(SetRightPanelResponseBody body) {
        this.body = body;
        return this;
    }
    public SetRightPanelResponseBody getBody() {
        return this.body;
    }

}
