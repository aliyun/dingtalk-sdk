// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetPatentInfoRequest extends TeaModel {
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

    public static GetPatentInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPatentInfoRequest self = new GetPatentInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPatentInfoRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetPatentInfoRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetPatentInfoRequest setSearchKey(String searchKey) {
        this.searchKey = searchKey;
        return this;
    }
    public String getSearchKey() {
        return this.searchKey;
    }

}
