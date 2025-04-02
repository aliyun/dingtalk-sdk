// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountSignUrlResponseBody extends TeaModel {
    @NameInMap("url")
    public String url;

    public static QueryEnterpriseAccountSignUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountSignUrlResponseBody self = new QueryEnterpriseAccountSignUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountSignUrlResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
