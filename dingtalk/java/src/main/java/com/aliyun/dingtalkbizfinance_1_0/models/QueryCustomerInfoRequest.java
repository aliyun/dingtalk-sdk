// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerInfoRequest extends TeaModel {
    // 客户名字
    @NameInMap("name")
    public String name;

    // 查询页码，从1开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 每页查询数量
    @NameInMap("pageSize")
    public Long pageSize;

    // 购方税号
    @NameInMap("purchaserTaxNo")
    public String purchaserTaxNo;

    // 购方电话
    @NameInMap("purchaserTel")
    public String purchaserTel;

    public static QueryCustomerInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerInfoRequest self = new QueryCustomerInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomerInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public QueryCustomerInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryCustomerInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryCustomerInfoRequest setPurchaserTaxNo(String purchaserTaxNo) {
        this.purchaserTaxNo = purchaserTaxNo;
        return this;
    }
    public String getPurchaserTaxNo() {
        return this.purchaserTaxNo;
    }

    public QueryCustomerInfoRequest setPurchaserTel(String purchaserTel) {
        this.purchaserTel = purchaserTel;
        return this;
    }
    public String getPurchaserTel() {
        return this.purchaserTel;
    }

}
