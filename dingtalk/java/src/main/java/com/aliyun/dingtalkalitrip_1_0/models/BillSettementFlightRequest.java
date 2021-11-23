// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementFlightRequest extends TeaModel {
    // 第三方企业ID
    @NameInMap("corpId")
    public String corpId;

    // 类目：机酒火车 1：机票； 2：酒店； 4：用车 6：商旅火车票
    @NameInMap("category")
    public Long category;

    // 每页数据量，默认100，最高500
    @NameInMap("pageSize")
    public Long pageSize;

    // 记账更新开始日期
    @NameInMap("periodStart")
    public String periodStart;

    // 页数，从1开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 记账更新结束日期
    @NameInMap("periodEnd")
    public String periodEnd;

    public static BillSettementFlightRequest build(java.util.Map<String, ?> map) throws Exception {
        BillSettementFlightRequest self = new BillSettementFlightRequest();
        return TeaModel.build(map, self);
    }

    public BillSettementFlightRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BillSettementFlightRequest setCategory(Long category) {
        this.category = category;
        return this;
    }
    public Long getCategory() {
        return this.category;
    }

    public BillSettementFlightRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public BillSettementFlightRequest setPeriodStart(String periodStart) {
        this.periodStart = periodStart;
        return this;
    }
    public String getPeriodStart() {
        return this.periodStart;
    }

    public BillSettementFlightRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public BillSettementFlightRequest setPeriodEnd(String periodEnd) {
        this.periodEnd = periodEnd;
        return this;
    }
    public String getPeriodEnd() {
        return this.periodEnd;
    }

}
