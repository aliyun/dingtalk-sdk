// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInterconnectionUrlResponseBody extends TeaModel {
    @NameInMap("url")
    public String url;

    public static GetInterconnectionUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInterconnectionUrlResponseBody self = new GetInterconnectionUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInterconnectionUrlResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
