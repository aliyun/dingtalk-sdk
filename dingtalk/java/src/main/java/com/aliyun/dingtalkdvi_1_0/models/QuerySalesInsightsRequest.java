// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QuerySalesInsightsRequest extends TeaModel {
    @NameInMap("analysisDate")
    public String analysisDate;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static QuerySalesInsightsRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySalesInsightsRequest self = new QuerySalesInsightsRequest();
        return TeaModel.build(map, self);
    }

    public QuerySalesInsightsRequest setAnalysisDate(String analysisDate) {
        this.analysisDate = analysisDate;
        return this;
    }
    public String getAnalysisDate() {
        return this.analysisDate;
    }

    public QuerySalesInsightsRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
