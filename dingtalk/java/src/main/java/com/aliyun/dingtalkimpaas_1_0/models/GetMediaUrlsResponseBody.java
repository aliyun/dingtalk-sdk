// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetMediaUrlsResponseBody extends TeaModel {
    @NameInMap("urls")
    public java.util.Map<String, ?> urls;

    public static GetMediaUrlsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMediaUrlsResponseBody self = new GetMediaUrlsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMediaUrlsResponseBody setUrls(java.util.Map<String, ?> urls) {
        this.urls = urls;
        return this;
    }
    public java.util.Map<String, ?> getUrls() {
        return this.urls;
    }

}
