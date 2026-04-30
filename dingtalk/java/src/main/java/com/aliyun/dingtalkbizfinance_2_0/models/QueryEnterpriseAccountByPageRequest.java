// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountByPageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("startStatus")
    public Boolean startStatus;

    public static QueryEnterpriseAccountByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountByPageRequest self = new QueryEnterpriseAccountByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryEnterpriseAccountByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryEnterpriseAccountByPageRequest setStartStatus(Boolean startStatus) {
        this.startStatus = startStatus;
        return this;
    }
    public Boolean getStartStatus() {
        return this.startStatus;
    }

}
