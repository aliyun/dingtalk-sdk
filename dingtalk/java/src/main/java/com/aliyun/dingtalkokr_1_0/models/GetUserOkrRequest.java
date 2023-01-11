// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetUserOkrRequest extends TeaModel {
    /**
     * <p>页码，默认 为 1。</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>每页的个数，默认100。</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>周期 ID。</p>
     */
    @NameInMap("periodId")
    public String periodId;

    /**
     * <p>当前用户的user ID。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetUserOkrRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserOkrRequest self = new GetUserOkrRequest();
        return TeaModel.build(map, self);
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

    public GetUserOkrRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public GetUserOkrRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
