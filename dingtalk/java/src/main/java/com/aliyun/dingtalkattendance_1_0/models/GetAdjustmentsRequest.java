// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetAdjustmentsRequest extends TeaModel {
    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    public static GetAdjustmentsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAdjustmentsRequest self = new GetAdjustmentsRequest();
        return TeaModel.build(map, self);
    }

    public GetAdjustmentsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetAdjustmentsRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
