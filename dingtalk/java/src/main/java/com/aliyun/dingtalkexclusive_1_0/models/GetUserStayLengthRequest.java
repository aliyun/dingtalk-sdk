// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserStayLengthRequest extends TeaModel {
    // 分页页数
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 统计日期（只保留当前日期的前30天）
    @NameInMap("statDate")
    public String statDate;

    public static GetUserStayLengthRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserStayLengthRequest self = new GetUserStayLengthRequest();
        return TeaModel.build(map, self);
    }

    public GetUserStayLengthRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetUserStayLengthRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetUserStayLengthRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
