// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QuerySalesInsightsShrinkRequest extends TeaModel {
    @NameInMap("analysisDate")
    public String analysisDate;

    @NameInMap("userIdList")
    public String userIdListShrink;

    public static QuerySalesInsightsShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySalesInsightsShrinkRequest self = new QuerySalesInsightsShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QuerySalesInsightsShrinkRequest setAnalysisDate(String analysisDate) {
        this.analysisDate = analysisDate;
        return this;
    }
    public String getAnalysisDate() {
        return this.analysisDate;
    }

    public QuerySalesInsightsShrinkRequest setUserIdListShrink(String userIdListShrink) {
        this.userIdListShrink = userIdListShrink;
        return this;
    }
    public String getUserIdListShrink() {
        return this.userIdListShrink;
    }

}
