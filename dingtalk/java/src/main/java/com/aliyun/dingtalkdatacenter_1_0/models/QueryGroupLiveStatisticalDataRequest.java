// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupLiveStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryGroupLiveStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupLiveStatisticalDataRequest self = new QueryGroupLiveStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupLiveStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
