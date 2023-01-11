// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydLogWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogWeekStatisticalDataRequest self = new QueryYydLogWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydLogWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
