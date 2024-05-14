// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetMediaUrlResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    public static GetMediaUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMediaUrlResponseBody self = new GetMediaUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMediaUrlResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
