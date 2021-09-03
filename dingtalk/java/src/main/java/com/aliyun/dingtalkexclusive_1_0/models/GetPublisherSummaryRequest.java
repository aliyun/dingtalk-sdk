// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublisherSummaryRequest extends TeaModel {
    // 启始数据游标
    @NameInMap("pageStart")
    public Long pageStart;

    // 每页包含的数据条数
    @NameInMap("pageSize")
    public Long pageSize;

    public static GetPublisherSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPublisherSummaryRequest self = new GetPublisherSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetPublisherSummaryRequest setPageStart(Long pageStart) {
        this.pageStart = pageStart;
        return this;
    }
    public Long getPageStart() {
        return this.pageStart;
    }

    public GetPublisherSummaryRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
