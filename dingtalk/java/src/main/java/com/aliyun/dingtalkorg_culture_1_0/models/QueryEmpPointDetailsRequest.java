// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryEmpPointDetailsRequest extends TeaModel {
    // 第几页 第一页是1
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 每页大小最多50 默认值10
    @NameInMap("pageSize")
    public Long pageSize;

    // 查询目标对象userId
    @NameInMap("userId")
    public String userId;

    public static QueryEmpPointDetailsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEmpPointDetailsRequest self = new QueryEmpPointDetailsRequest();
        return TeaModel.build(map, self);
    }

    public QueryEmpPointDetailsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryEmpPointDetailsRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryEmpPointDetailsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
