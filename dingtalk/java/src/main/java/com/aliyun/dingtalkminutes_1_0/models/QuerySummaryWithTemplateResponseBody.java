// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySummaryWithTemplateResponseBody extends TeaModel {
    @NameInMap("summaryText")
    public String summaryText;

    public static QuerySummaryWithTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySummaryWithTemplateResponseBody self = new QuerySummaryWithTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySummaryWithTemplateResponseBody setSummaryText(String summaryText) {
        this.summaryText = summaryText;
        return this;
    }
    public String getSummaryText() {
        return this.summaryText;
    }

}
