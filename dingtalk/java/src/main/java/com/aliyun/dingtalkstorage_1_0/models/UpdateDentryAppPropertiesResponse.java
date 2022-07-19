// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdateDentryAppPropertiesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDentryAppPropertiesResponseBody body;

    public static UpdateDentryAppPropertiesResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateDentryAppPropertiesResponse self = new UpdateDentryAppPropertiesResponse();
        return TeaModel.build(map, self);
    }

    public UpdateDentryAppPropertiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateDentryAppPropertiesResponse setBody(UpdateDentryAppPropertiesResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateDentryAppPropertiesResponseBody getBody() {
        return this.body;
    }

}
