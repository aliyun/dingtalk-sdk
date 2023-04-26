// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDingSendStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryDingSendStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDingSendStatisticalDataRequest self = new QueryDingSendStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryDingSendStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
