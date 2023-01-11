// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppHistoryVersionRequest extends TeaModel {
    /**
     * <p>小程序id</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>分页码</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static ListMiniAppHistoryVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppHistoryVersionRequest self = new ListMiniAppHistoryVersionRequest();
        return TeaModel.build(map, self);
    }

    public ListMiniAppHistoryVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ListMiniAppHistoryVersionRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ListMiniAppHistoryVersionRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
