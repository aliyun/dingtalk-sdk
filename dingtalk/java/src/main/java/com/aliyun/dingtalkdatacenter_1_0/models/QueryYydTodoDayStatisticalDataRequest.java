// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTodoDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoDayStatisticalDataRequest self = new QueryYydTodoDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
