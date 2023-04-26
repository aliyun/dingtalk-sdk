// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoMonthStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTodoMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoMonthStatisticalDataRequest self = new QueryYydTodoMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
