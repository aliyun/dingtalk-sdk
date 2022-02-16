// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydMeetingWeekStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydMeetingWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydMeetingWeekStatisticalDataRequest self = new QueryYydMeetingWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydMeetingWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
