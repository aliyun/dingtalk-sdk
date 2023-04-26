// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveDayStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydActiveDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveDayStatisticalDataRequest self = new QueryYydActiveDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
