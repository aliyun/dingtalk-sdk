// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesMeetingResultResponseBody extends TeaModel {
    @NameInMap("action")
    public java.util.List<String> action;

    @NameInMap("fullSummary")
    public String fullSummary;

    public static QueryMinutesMeetingResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesMeetingResultResponseBody self = new QueryMinutesMeetingResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesMeetingResultResponseBody setAction(java.util.List<String> action) {
        this.action = action;
        return this;
    }
    public java.util.List<String> getAction() {
        return this.action;
    }

    public QueryMinutesMeetingResultResponseBody setFullSummary(String fullSummary) {
        this.fullSummary = fullSummary;
        return this;
    }
    public String getFullSummary() {
        return this.fullSummary;
    }

}
