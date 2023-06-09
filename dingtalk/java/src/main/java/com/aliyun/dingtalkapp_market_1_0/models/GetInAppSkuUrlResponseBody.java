// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetInAppSkuUrlResponseBody extends TeaModel {
    @NameInMap("url")
    public String url;

    public static GetInAppSkuUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInAppSkuUrlResponseBody self = new GetInAppSkuUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInAppSkuUrlResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
