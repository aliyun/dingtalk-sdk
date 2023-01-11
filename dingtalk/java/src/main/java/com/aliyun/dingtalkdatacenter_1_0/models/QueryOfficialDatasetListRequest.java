// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetListRequest extends TeaModel {
    /**
     * <p>关键词搜索</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>起始页，从1开始</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>单页大小，最大100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryOfficialDatasetListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetListRequest self = new QueryOfficialDatasetListRequest();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetListRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public QueryOfficialDatasetListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryOfficialDatasetListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
