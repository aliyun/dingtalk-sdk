// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedDeptSummaryRequest extends TeaModel {
    // 启始数据游标
    @NameInMap("pageStart")
    public Long pageStart;

    // 每页包含的数据条数
    @NameInMap("pageSize")
    public Long pageSize;

    public static GetDocCreatedDeptSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedDeptSummaryRequest self = new GetDocCreatedDeptSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedDeptSummaryRequest setPageStart(Long pageStart) {
        this.pageStart = pageStart;
        return this;
    }
    public Long getPageStart() {
        return this.pageStart;
    }

    public GetDocCreatedDeptSummaryRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
