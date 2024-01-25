// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchProjectTemplateResponseBody body;

    public static SearchProjectTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectTemplateResponse self = new SearchProjectTemplateResponse();
        return TeaModel.build(map, self);
    }

    public SearchProjectTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchProjectTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchProjectTemplateResponse setBody(SearchProjectTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchProjectTemplateResponseBody getBody() {
        return this.body;
    }

}
