// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantMessageRequest extends TeaModel {
    @NameInMap("limit")
    public Integer limit;

    @NameInMap("order")
    public String order;

    @NameInMap("runId")
    public String runId;

    public static ListAssistantMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantMessageRequest self = new ListAssistantMessageRequest();
        return TeaModel.build(map, self);
    }

    public ListAssistantMessageRequest setLimit(Integer limit) {
        this.limit = limit;
        return this;
    }
    public Integer getLimit() {
        return this.limit;
    }

    public ListAssistantMessageRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

    public ListAssistantMessageRequest setRunId(String runId) {
        this.runId = runId;
        return this;
    }
    public String getRunId() {
        return this.runId;
    }

}
