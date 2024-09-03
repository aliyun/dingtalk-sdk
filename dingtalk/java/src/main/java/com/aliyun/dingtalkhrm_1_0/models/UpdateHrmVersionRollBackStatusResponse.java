// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmVersionRollBackStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateHrmVersionRollBackStatusResponseBody body;

    public static UpdateHrmVersionRollBackStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmVersionRollBackStatusResponse self = new UpdateHrmVersionRollBackStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateHrmVersionRollBackStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateHrmVersionRollBackStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateHrmVersionRollBackStatusResponse setBody(UpdateHrmVersionRollBackStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateHrmVersionRollBackStatusResponseBody getBody() {
        return this.body;
    }

}
