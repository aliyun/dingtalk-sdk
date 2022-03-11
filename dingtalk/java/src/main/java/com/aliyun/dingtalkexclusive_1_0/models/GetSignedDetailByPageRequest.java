// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSignedDetailByPageRequest extends TeaModel {
    // pageStart
    @NameInMap("pageNumber")
    public Long pageNumber;

    // pageSize
    @NameInMap("pageSize")
    public Long pageSize;

    // signStatus
    @NameInMap("signStatus")
    public Long signStatus;

    public static GetSignedDetailByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignedDetailByPageRequest self = new GetSignedDetailByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetSignedDetailByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetSignedDetailByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetSignedDetailByPageRequest setSignStatus(Long signStatus) {
        this.signStatus = signStatus;
        return this;
    }
    public Long getSignStatus() {
        return this.signStatus;
    }

}
