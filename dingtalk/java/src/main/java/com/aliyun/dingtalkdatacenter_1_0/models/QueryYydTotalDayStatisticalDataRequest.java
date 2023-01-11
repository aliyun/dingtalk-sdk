// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTotalDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalDayStatisticalDataRequest self = new QueryYydTotalDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
