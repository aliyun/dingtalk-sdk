// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCircleStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryCircleStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCircleStatisticalDataRequest self = new QueryCircleStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryCircleStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
