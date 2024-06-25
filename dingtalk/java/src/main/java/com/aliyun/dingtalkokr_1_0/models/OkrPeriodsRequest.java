// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrPeriodsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingOKR</p>
     */
    @NameInMap("goodsCode")
    public String goodsCode;

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

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("status")
    public Long status;

    public static OkrPeriodsRequest build(java.util.Map<String, ?> map) throws Exception {
        OkrPeriodsRequest self = new OkrPeriodsRequest();
        return TeaModel.build(map, self);
    }

    public OkrPeriodsRequest setGoodsCode(String goodsCode) {
        this.goodsCode = goodsCode;
        return this;
    }
    public String getGoodsCode() {
        return this.goodsCode;
    }

    public OkrPeriodsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public OkrPeriodsRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public OkrPeriodsRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
