// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByAppUidsRequest extends TeaModel {
    @NameInMap("appUids")
    public java.util.List<Long> appUids;

    public static QueryGroupMemberByAppUidsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberByAppUidsRequest self = new QueryGroupMemberByAppUidsRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberByAppUidsRequest setAppUids(java.util.List<Long> appUids) {
        this.appUids = appUids;
        return this;
    }
    public java.util.List<Long> getAppUids() {
        return this.appUids;
    }

}
