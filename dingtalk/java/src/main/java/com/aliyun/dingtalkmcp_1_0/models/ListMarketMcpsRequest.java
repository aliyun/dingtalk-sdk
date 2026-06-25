// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ListMarketMcpsRequest extends TeaModel {
    @NameInMap("page")
    public Integer page;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static ListMarketMcpsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMarketMcpsRequest self = new ListMarketMcpsRequest();
        return TeaModel.build(map, self);
    }

    public ListMarketMcpsRequest setPage(Integer page) {
        this.page = page;
        return this;
    }
    public Integer getPage() {
        return this.page;
    }

    public ListMarketMcpsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
