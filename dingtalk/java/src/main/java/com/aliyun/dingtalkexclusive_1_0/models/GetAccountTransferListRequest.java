// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAccountTransferListRequest extends TeaModel {
    // 分页页数
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 迁移状态0-未迁移，1-已迁移，2-无需迁移
    @NameInMap("status")
    public Long status;

    public static GetAccountTransferListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAccountTransferListRequest self = new GetAccountTransferListRequest();
        return TeaModel.build(map, self);
    }

    public GetAccountTransferListRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetAccountTransferListRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetAccountTransferListRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
