// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class OpenQueryMinutesSummaryResponseBody extends TeaModel {
    @NameInMap("fullSummary")
    public String fullSummary;

    public static OpenQueryMinutesSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenQueryMinutesSummaryResponseBody self = new OpenQueryMinutesSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenQueryMinutesSummaryResponseBody setFullSummary(String fullSummary) {
        this.fullSummary = fullSummary;
        return this;
    }
    public String getFullSummary() {
        return this.fullSummary;
    }

}
