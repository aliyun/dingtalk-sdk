// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydMeetingMonthStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydMeetingMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydMeetingMonthStatisticalDataRequest self = new QueryYydMeetingMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydMeetingMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}