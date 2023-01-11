// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydNoticeDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeDayStatisticalDataRequest self = new QueryYydNoticeDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
