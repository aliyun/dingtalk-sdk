// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceListByCorpIdRequest extends TeaModel {
    @NameInMap("operator")
    public String operator;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryDeviceListByCorpIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceListByCorpIdRequest self = new QueryDeviceListByCorpIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryDeviceListByCorpIdRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public QueryDeviceListByCorpIdRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryDeviceListByCorpIdRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
