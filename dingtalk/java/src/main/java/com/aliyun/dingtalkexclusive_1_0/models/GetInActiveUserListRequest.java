// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetInActiveUserListRequest extends TeaModel {
    @NameInMap("deptIds")
    public java.util.List<String> deptIds;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("statDate")
    public String statDate;

    public static GetInActiveUserListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInActiveUserListRequest self = new GetInActiveUserListRequest();
        return TeaModel.build(map, self);
    }

    public GetInActiveUserListRequest setDeptIds(java.util.List<String> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<String> getDeptIds() {
        return this.deptIds;
    }

    public GetInActiveUserListRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetInActiveUserListRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetInActiveUserListRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
