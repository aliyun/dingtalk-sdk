// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementBtripTrainRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("category")
    public Long category;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("periodStart")
    public String periodStart;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("periodEnd")
    public String periodEnd;

    public static BillSettementBtripTrainRequest build(java.util.Map<String, ?> map) throws Exception {
        BillSettementBtripTrainRequest self = new BillSettementBtripTrainRequest();
        return TeaModel.build(map, self);
    }

    public BillSettementBtripTrainRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BillSettementBtripTrainRequest setCategory(Long category) {
        this.category = category;
        return this;
    }
    public Long getCategory() {
        return this.category;
    }

    public BillSettementBtripTrainRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public BillSettementBtripTrainRequest setPeriodStart(String periodStart) {
        this.periodStart = periodStart;
        return this;
    }
    public String getPeriodStart() {
        return this.periodStart;
    }

    public BillSettementBtripTrainRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public BillSettementBtripTrainRequest setPeriodEnd(String periodEnd) {
        this.periodEnd = periodEnd;
        return this;
    }
    public String getPeriodEnd() {
        return this.periodEnd;
    }

}
