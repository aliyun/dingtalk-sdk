// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectsV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchProjectsV3ResponseBody body;

    public static SearchProjectsV3Response build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectsV3Response self = new SearchProjectsV3Response();
        return TeaModel.build(map, self);
    }

    public SearchProjectsV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchProjectsV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchProjectsV3Response setBody(SearchProjectsV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchProjectsV3ResponseBody getBody() {
        return this.body;
    }

}
