// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementHotelRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("category")
    public Long category;

    /**
     * <strong>example:</strong>
     * <p>corpx</p>
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
     * <p>100</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>2021-10-01</p>
     */
    @NameInMap("periodEnd")
    public String periodEnd;

    /**
     * <strong>example:</strong>
     * <p>2021-10-01</p>
     */
    @NameInMap("periodStart")
    public String periodStart;

    public static BillSettementHotelRequest build(java.util.Map<String, ?> map) throws Exception {
        BillSettementHotelRequest self = new BillSettementHotelRequest();
        return TeaModel.build(map, self);
    }

    public BillSettementHotelRequest setCategory(Long category) {
        this.category = category;
        return this;
    }
    public Long getCategory() {
        return this.category;
    }

    public BillSettementHotelRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BillSettementHotelRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public BillSettementHotelRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public BillSettementHotelRequest setPeriodEnd(String periodEnd) {
        this.periodEnd = periodEnd;
        return this;
    }
    public String getPeriodEnd() {
        return this.periodEnd;
    }

    public BillSettementHotelRequest setPeriodStart(String periodStart) {
        this.periodStart = periodStart;
        return this;
    }
    public String getPeriodStart() {
        return this.periodStart;
    }

}
