// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryAnhmdStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryAnhmdStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAnhmdStatisticalDataRequest self = new QueryAnhmdStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryAnhmdStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
