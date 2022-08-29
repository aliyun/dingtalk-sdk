// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEnvironmentalPenaltiesRequest extends TeaModel {
    // 页数,第几页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 每页条数
    @NameInMap("pageSize")
    public Integer pageSize;

    // 关键词
    @NameInMap("searchKey")
    public String searchKey;

    public static GetEnvironmentalPenaltiesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEnvironmentalPenaltiesRequest self = new GetEnvironmentalPenaltiesRequest();
        return TeaModel.build(map, self);
    }

    public GetEnvironmentalPenaltiesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetEnvironmentalPenaltiesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetEnvironmentalPenaltiesRequest setSearchKey(String searchKey) {
        this.searchKey = searchKey;
        return this;
    }
    public String getSearchKey() {
        return this.searchKey;
    }

}
