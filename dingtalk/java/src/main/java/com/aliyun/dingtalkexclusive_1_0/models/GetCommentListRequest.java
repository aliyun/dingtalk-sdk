// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCommentListRequest extends TeaModel {
    // 分页起始页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Long pageSize;

    public static GetCommentListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCommentListRequest self = new GetCommentListRequest();
        return TeaModel.build(map, self);
    }

    public GetCommentListRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetCommentListRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
