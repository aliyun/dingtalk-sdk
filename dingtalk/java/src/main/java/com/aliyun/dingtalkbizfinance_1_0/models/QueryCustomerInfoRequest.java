// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerInfoRequest extends TeaModel {
    /**
     * <p>查询条件，目前支持 名字、税号、购方电话</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>查询页码，从1开始</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>每页查询数量</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryCustomerInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerInfoRequest self = new QueryCustomerInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomerInfoRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public QueryCustomerInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryCustomerInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
