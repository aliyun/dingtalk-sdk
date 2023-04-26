// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryHealthStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryHealthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHealthStatisticalDataRequest self = new QueryHealthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryHealthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
