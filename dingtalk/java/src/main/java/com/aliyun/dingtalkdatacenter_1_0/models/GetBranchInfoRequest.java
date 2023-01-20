// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBranchInfoRequest extends TeaModel {
    /**
     * <p>页数,第几页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>每页条数</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>关键词</p>
     */
    @NameInMap("searchKey")
    public String searchKey;

    public static GetBranchInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBranchInfoRequest self = new GetBranchInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetBranchInfoRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetBranchInfoRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetBranchInfoRequest setSearchKey(String searchKey) {
        this.searchKey = searchKey;
        return this;
    }
    public String getSearchKey() {
        return this.searchKey;
    }

}
