// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementBtripTrainRequest extends TeaModel {
    @NameInMap("category")
    public Long category;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("periodEnd")
    public String periodEnd;

    @NameInMap("periodStart")
    public String periodStart;

    public static BillSettementBtripTrainRequest build(java.util.Map<String, ?> map) throws Exception {
        BillSettementBtripTrainRequest self = new BillSettementBtripTrainRequest();
        return TeaModel.build(map, self);
    }

    public BillSettementBtripTrainRequest setCategory(Long category) {
        this.category = category;
        return this;
    }
    public Long getCategory() {
        return this.category;
    }

    public BillSettementBtripTrainRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BillSettementBtripTrainRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public BillSettementBtripTrainRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public BillSettementBtripTrainRequest setPeriodEnd(String periodEnd) {
        this.periodEnd = periodEnd;
        return this;
    }
    public String getPeriodEnd() {
        return this.periodEnd;
    }

    public BillSettementBtripTrainRequest setPeriodStart(String periodStart) {
        this.periodStart = periodStart;
        return this;
    }
    public String getPeriodStart() {
        return this.periodStart;
    }

}
