// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryApprovalStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryApprovalStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryApprovalStatisticalDataRequest self = new QueryApprovalStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryApprovalStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
