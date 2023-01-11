// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetOssTempUrlResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("url")
    public String url;

    public static GetOssTempUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOssTempUrlResponseBody self = new GetOssTempUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOssTempUrlResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
