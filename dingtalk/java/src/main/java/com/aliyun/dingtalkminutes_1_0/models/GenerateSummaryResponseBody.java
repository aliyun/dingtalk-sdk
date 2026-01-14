// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class GenerateSummaryResponseBody extends TeaModel {
    @NameInMap("summaryText")
    public String summaryText;

    @NameInMap("taskUuid")
    public String taskUuid;

    public static GenerateSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GenerateSummaryResponseBody self = new GenerateSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GenerateSummaryResponseBody setSummaryText(String summaryText) {
        this.summaryText = summaryText;
        return this;
    }
    public String getSummaryText() {
        return this.summaryText;
    }

    public GenerateSummaryResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
