// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppWeekStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydAppWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppWeekStatisticalDataRequest self = new QueryYydAppWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydAppWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
