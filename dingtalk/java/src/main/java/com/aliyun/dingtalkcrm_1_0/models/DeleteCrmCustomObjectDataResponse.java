// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmCustomObjectDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteCrmCustomObjectDataResponseBody body;

    public static DeleteCrmCustomObjectDataResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmCustomObjectDataResponse self = new DeleteCrmCustomObjectDataResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCrmCustomObjectDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCrmCustomObjectDataResponse setBody(DeleteCrmCustomObjectDataResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCrmCustomObjectDataResponseBody getBody() {
        return this.body;
    }

}
