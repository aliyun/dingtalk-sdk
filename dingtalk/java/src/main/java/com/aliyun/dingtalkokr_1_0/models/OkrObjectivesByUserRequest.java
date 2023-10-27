// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrObjectivesByUserRequest extends TeaModel {
    @NameInMap("goodsCode")
    public String goodsCode;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static OkrObjectivesByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        OkrObjectivesByUserRequest self = new OkrObjectivesByUserRequest();
        return TeaModel.build(map, self);
    }

    public OkrObjectivesByUserRequest setGoodsCode(String goodsCode) {
        this.goodsCode = goodsCode;
        return this;
    }
    public String getGoodsCode() {
        return this.goodsCode;
    }

    public OkrObjectivesByUserRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public OkrObjectivesByUserRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
