// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementCarRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("category")
    public Long category;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("periodStart")
    public String periodStart;

    @NameInMap("periodEnd")
    public String periodEnd;

    @NameInMap("pageNumber")
    public Long pageNumber;

    public static BillSettementCarRequest build(java.util.Map<String, ?> map) throws Exception {
        BillSettementCarRequest self = new BillSettementCarRequest();
        return TeaModel.build(map, self);
    }

    public BillSettementCarRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BillSettementCarRequest setCategory(Long category) {
        this.category = category;
        return this;
    }
    public Long getCategory() {
        return this.category;
    }

    public BillSettementCarRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public BillSettementCarRequest setPeriodStart(String periodStart) {
        this.periodStart = periodStart;
        return this;
    }
    public String getPeriodStart() {
        return this.periodStart;
    }

    public BillSettementCarRequest setPeriodEnd(String periodEnd) {
        this.periodEnd = periodEnd;
        return this;
    }
    public String getPeriodEnd() {
        return this.periodEnd;
    }

    public BillSettementCarRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

}
