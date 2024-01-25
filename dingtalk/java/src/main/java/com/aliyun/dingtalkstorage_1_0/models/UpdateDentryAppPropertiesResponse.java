// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdateDentryAppPropertiesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateDentryAppPropertiesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateDentryAppPropertiesResponse setBody(UpdateDentryAppPropertiesResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateDentryAppPropertiesResponseBody getBody() {
        return this.body;
    }

}
