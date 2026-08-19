// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryFileProcessResultRequest extends TeaModel {
    @NameInMap("renderTaskId")
    public String renderTaskId;

    public static QueryFileProcessResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryFileProcessResultRequest self = new QueryFileProcessResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryFileProcessResultRequest setRenderTaskId(String renderTaskId) {
        this.renderTaskId = renderTaskId;
        return this;
    }
    public String getRenderTaskId() {
        return this.renderTaskId;
    }

}
