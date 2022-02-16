// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveMonthStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydActiveMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveMonthStatisticalDataRequest self = new QueryYydActiveMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
