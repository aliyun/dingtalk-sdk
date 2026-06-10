// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ListWorkflowsRequest extends TeaModel {
    @NameInMap("limit")
    public Long limit;

    @NameInMap("offset")
    public Long offset;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ListWorkflowsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListWorkflowsRequest self = new ListWorkflowsRequest();
        return TeaModel.build(map, self);
    }

    public ListWorkflowsRequest setLimit(Long limit) {
        this.limit = limit;
        return this;
    }
    public Long getLimit() {
        return this.limit;
    }

    public ListWorkflowsRequest setOffset(Long offset) {
        this.offset = offset;
        return this;
    }
    public Long getOffset() {
        return this.offset;
    }

    public ListWorkflowsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
