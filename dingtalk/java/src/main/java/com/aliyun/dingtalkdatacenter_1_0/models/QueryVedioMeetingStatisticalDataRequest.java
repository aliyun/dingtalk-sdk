// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryVedioMeetingStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryVedioMeetingStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryVedioMeetingStatisticalDataRequest self = new QueryVedioMeetingStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryVedioMeetingStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
