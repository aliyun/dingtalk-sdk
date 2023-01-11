// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydActiveWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveWeekStatisticalDataRequest self = new QueryYydActiveWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
