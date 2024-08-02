// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryMicroAppViewRequest extends TeaModel {
    @NameInMap("tenantIdList")
    public java.util.List<Long> tenantIdList;

    /**
     * <strong>example:</strong>
     * <p>2163515669935611</p>
     */
    @NameInMap("viewUserId")
    public String viewUserId;

    public static QueryMicroAppViewRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMicroAppViewRequest self = new QueryMicroAppViewRequest();
        return TeaModel.build(map, self);
    }

    public QueryMicroAppViewRequest setTenantIdList(java.util.List<Long> tenantIdList) {
        this.tenantIdList = tenantIdList;
        return this;
    }
    public java.util.List<Long> getTenantIdList() {
        return this.tenantIdList;
    }

    public QueryMicroAppViewRequest setViewUserId(String viewUserId) {
        this.viewUserId = viewUserId;
        return this;
    }
    public String getViewUserId() {
        return this.viewUserId;
    }

}
