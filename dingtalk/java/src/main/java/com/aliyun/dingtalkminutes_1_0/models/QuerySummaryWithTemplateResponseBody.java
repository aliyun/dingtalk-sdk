// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySummaryWithTemplateResponseBody extends TeaModel {
    @NameInMap("generatingStatus")
    public String generatingStatus;

    @NameInMap("summaryText")
    public String summaryText;

    @NameInMap("visualGeneratingStatus")
    public String visualGeneratingStatus;

    public static QuerySummaryWithTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySummaryWithTemplateResponseBody self = new QuerySummaryWithTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySummaryWithTemplateResponseBody setGeneratingStatus(String generatingStatus) {
        this.generatingStatus = generatingStatus;
        return this;
    }
    public String getGeneratingStatus() {
        return this.generatingStatus;
    }

    public QuerySummaryWithTemplateResponseBody setSummaryText(String summaryText) {
        this.summaryText = summaryText;
        return this;
    }
    public String getSummaryText() {
        return this.summaryText;
    }

    public QuerySummaryWithTemplateResponseBody setVisualGeneratingStatus(String visualGeneratingStatus) {
        this.visualGeneratingStatus = visualGeneratingStatus;
        return this;
    }
    public String getVisualGeneratingStatus() {
        return this.visualGeneratingStatus;
    }

}
