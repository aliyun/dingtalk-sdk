// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseCodeOpenDetailResponseBody extends TeaModel {
    @NameInMap("enterpriseId")
    public String enterpriseId;

    @NameInMap("openedStatus")
    public Boolean openedStatus;

    public static QueryEnterpriseCodeOpenDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseCodeOpenDetailResponseBody self = new QueryEnterpriseCodeOpenDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseCodeOpenDetailResponseBody setEnterpriseId(String enterpriseId) {
        this.enterpriseId = enterpriseId;
        return this;
    }
    public String getEnterpriseId() {
        return this.enterpriseId;
    }

    public QueryEnterpriseCodeOpenDetailResponseBody setOpenedStatus(Boolean openedStatus) {
        this.openedStatus = openedStatus;
        return this;
    }
    public Boolean getOpenedStatus() {
        return this.openedStatus;
    }

}
