// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListTableDataByFormInstanceIdTableIdResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<java.util.Map<String, ?>> data;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("totalCount")
    public Long totalCount;

    public static ListTableDataByFormInstanceIdTableIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTableDataByFormInstanceIdTableIdResponseBody self = new ListTableDataByFormInstanceIdTableIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTableDataByFormInstanceIdTableIdResponseBody setData(java.util.List<java.util.Map<String, ?>> data) {
        this.data = data;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getData() {
        return this.data;
    }

    public ListTableDataByFormInstanceIdTableIdResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ListTableDataByFormInstanceIdTableIdResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

}
