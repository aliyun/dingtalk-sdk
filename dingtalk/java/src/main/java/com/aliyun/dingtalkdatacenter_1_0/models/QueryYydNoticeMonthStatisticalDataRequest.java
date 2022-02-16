// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeMonthStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydNoticeMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeMonthStatisticalDataRequest self = new QueryYydNoticeMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
