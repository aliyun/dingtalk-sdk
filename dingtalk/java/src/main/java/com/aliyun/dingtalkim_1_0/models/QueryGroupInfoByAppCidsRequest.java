// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByAppCidsRequest extends TeaModel {
    @NameInMap("appCids")
    public java.util.List<String> appCids;

    public static QueryGroupInfoByAppCidsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByAppCidsRequest self = new QueryGroupInfoByAppCidsRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByAppCidsRequest setAppCids(java.util.List<String> appCids) {
        this.appCids = appCids;
        return this;
    }
    public java.util.List<String> getAppCids() {
        return this.appCids;
    }

}
