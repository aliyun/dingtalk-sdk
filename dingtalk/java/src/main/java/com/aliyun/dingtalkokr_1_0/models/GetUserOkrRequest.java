// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetUserOkrRequest extends TeaModel {
    // 归属用户的ID
    @NameInMap("ownerId")
    public java.io.InputStream ownerId;

    // 页码，默认 为 1
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 每页的个数，默认100
    @NameInMap("pageSize")
    public Long pageSize;

    // 周期 ID
    @NameInMap("periodId")
    public java.io.InputStream periodId;

    public static GetUserOkrRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserOkrRequest self = new GetUserOkrRequest();
        return TeaModel.build(map, self);
    }

    public GetUserOkrRequest setOwnerId(java.io.InputStream ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public java.io.InputStream getOwnerId() {
        return this.ownerId;
    }

    public GetUserOkrRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetUserOkrRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetUserOkrRequest setPeriodId(java.io.InputStream periodId) {
        this.periodId = periodId;
        return this;
    }
    public java.io.InputStream getPeriodId() {
        return this.periodId;
    }

}
