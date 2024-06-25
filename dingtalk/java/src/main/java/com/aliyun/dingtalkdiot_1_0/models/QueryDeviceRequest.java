// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceRequest self = new QueryDeviceRequest();
        return TeaModel.build(map, self);
    }

    public QueryDeviceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryDeviceRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryDeviceRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
