// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceIdListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<String> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetInstanceIdListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceIdListResponseBody self = new GetInstanceIdListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInstanceIdListResponseBody setData(java.util.List<String> data) {
        this.data = data;
        return this;
    }
    public java.util.List<String> getData() {
        return this.data;
    }

    public GetInstanceIdListResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetInstanceIdListResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

}
