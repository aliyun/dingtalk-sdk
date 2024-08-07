// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantRunRequest extends TeaModel {
    @NameInMap("limit")
    public Integer limit;

    @NameInMap("order")
    public String order;

    public static ListAssistantRunRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantRunRequest self = new ListAssistantRunRequest();
        return TeaModel.build(map, self);
    }

    public ListAssistantRunRequest setLimit(Integer limit) {
        this.limit = limit;
        return this;
    }
    public Integer getLimit() {
        return this.limit;
    }

    public ListAssistantRunRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

}
