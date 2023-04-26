// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryReportStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryReportStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReportStatisticalDataRequest self = new QueryReportStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryReportStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
