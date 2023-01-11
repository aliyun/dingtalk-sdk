// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydLogDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogDayStatisticalDataRequest self = new QueryYydLogDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydLogDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
