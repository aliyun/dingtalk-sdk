// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydNoticeWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeWeekStatisticalDataRequest self = new QueryYydNoticeWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
