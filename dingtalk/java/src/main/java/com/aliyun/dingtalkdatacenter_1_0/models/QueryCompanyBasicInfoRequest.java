// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyBasicInfoRequest extends TeaModel {
    @NameInMap("keyword")
    public String keyword;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryCompanyBasicInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCompanyBasicInfoRequest self = new QueryCompanyBasicInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryCompanyBasicInfoRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public QueryCompanyBasicInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryCompanyBasicInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
