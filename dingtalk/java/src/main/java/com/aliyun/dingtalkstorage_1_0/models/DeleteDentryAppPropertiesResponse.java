// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryAppPropertiesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteDentryAppPropertiesResponseBody body;

    public static DeleteDentryAppPropertiesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryAppPropertiesResponse self = new DeleteDentryAppPropertiesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDentryAppPropertiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDentryAppPropertiesResponse setBody(DeleteDentryAppPropertiesResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDentryAppPropertiesResponseBody getBody() {
        return this.body;
    }

}
