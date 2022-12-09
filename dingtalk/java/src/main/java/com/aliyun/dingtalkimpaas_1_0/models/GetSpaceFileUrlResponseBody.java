// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceFileUrlResponseBody extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, ?> headers;

    @NameInMap("internalResourceUrl")
    public String internalResourceUrl;

    @NameInMap("resourceUrl")
    public String resourceUrl;

    public static GetSpaceFileUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceFileUrlResponseBody self = new GetSpaceFileUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpaceFileUrlResponseBody setHeaders(java.util.Map<String, ?> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, ?> getHeaders() {
        return this.headers;
    }

    public GetSpaceFileUrlResponseBody setInternalResourceUrl(String internalResourceUrl) {
        this.internalResourceUrl = internalResourceUrl;
        return this;
    }
    public String getInternalResourceUrl() {
        return this.internalResourceUrl;
    }

    public GetSpaceFileUrlResponseBody setResourceUrl(String resourceUrl) {
        this.resourceUrl = resourceUrl;
        return this;
    }
    public String getResourceUrl() {
        return this.resourceUrl;
    }

}
