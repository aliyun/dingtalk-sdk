// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCheckinStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryCheckinStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCheckinStatisticalDataRequest self = new QueryCheckinStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryCheckinStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
