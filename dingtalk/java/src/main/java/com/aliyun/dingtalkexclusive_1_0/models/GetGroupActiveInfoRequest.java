// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupActiveInfoRequest extends TeaModel {
    @NameInMap("dingGroupId")
    public String dingGroupId;

    @NameInMap("groupType")
    public Long groupType;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("statDate")
    public String statDate;

    public static GetGroupActiveInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupActiveInfoRequest self = new GetGroupActiveInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupActiveInfoRequest setDingGroupId(String dingGroupId) {
        this.dingGroupId = dingGroupId;
        return this;
    }
    public String getDingGroupId() {
        return this.dingGroupId;
    }

    public GetGroupActiveInfoRequest setGroupType(Long groupType) {
        this.groupType = groupType;
        return this;
    }
    public Long getGroupType() {
        return this.groupType;
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

    public GetGroupActiveInfoRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
