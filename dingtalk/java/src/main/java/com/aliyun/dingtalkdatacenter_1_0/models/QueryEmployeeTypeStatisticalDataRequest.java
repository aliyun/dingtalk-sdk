// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryEmployeeTypeStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryEmployeeTypeStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEmployeeTypeStatisticalDataRequest self = new QueryEmployeeTypeStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryEmployeeTypeStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
