// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalStdStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTotalStdStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalStdStatisticalDataRequest self = new QueryYydTotalStdStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalStdStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
