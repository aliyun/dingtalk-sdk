// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceRequest extends TeaModel {
    /**
     * <p>钉钉组织id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>指定显示返回结果中的第几页的内容。默认值是 1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>指定返回结果中每页显示的记录数量，最大值是50。默认值是10</p>
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
