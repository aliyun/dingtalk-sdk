// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupActiveInfoRequest extends TeaModel {
    // 统计日期
    @NameInMap("statDate")
    public String statDate;

    // 钉钉群组id
    @NameInMap("dingGroupId")
    public String dingGroupId;

    // 分页起始页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Long pageSize;

    public static GetGroupActiveInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupActiveInfoRequest self = new GetGroupActiveInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupActiveInfoRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

    public GetGroupActiveInfoRequest setDingGroupId(String dingGroupId) {
        this.dingGroupId = dingGroupId;
        return this;
    }
    public String getDingGroupId() {
        return this.dingGroupId;
    }

    public GetGroupActiveInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetGroupActiveInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
