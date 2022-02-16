// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppStdStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydAppStdStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppStdStatisticalDataRequest self = new QueryYydAppStdStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydAppStdStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
