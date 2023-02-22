// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PageInnerAppHistoryVersionRequest extends TeaModel {
    /**
     * <p>当前页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>本次读取的最大数据记录数量</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static PageInnerAppHistoryVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        PageInnerAppHistoryVersionRequest self = new PageInnerAppHistoryVersionRequest();
        return TeaModel.build(map, self);
    }

    public PageInnerAppHistoryVersionRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PageInnerAppHistoryVersionRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
