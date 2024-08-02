// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryMicroAppStatusRequest extends TeaModel {
    @NameInMap("tenantIdList")
    public java.util.List<Long> tenantIdList;

    public static QueryMicroAppStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMicroAppStatusRequest self = new QueryMicroAppStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryMicroAppStatusRequest setTenantIdList(java.util.List<Long> tenantIdList) {
        this.tenantIdList = tenantIdList;
        return this;
    }
    public java.util.List<Long> getTenantIdList() {
        return this.tenantIdList;
    }

}
