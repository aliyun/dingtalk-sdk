// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetLatestDingIndexResponseBody extends TeaModel {
    // 日期
    @NameInMap("statDate")
    public String statDate;

    // 钉钉指数
    @NameInMap("idxTotal")
    public Float idxTotal;

    // 效率指数
    @NameInMap("idxEfficiency")
    public Float idxEfficiency;

    // 绿色指数
    @NameInMap("idxCarbon")
    public Float idxCarbon;

    // 钉钉指数月均分
    @NameInMap("idxMonthlyAvg")
    public Float idxMonthlyAvg;

    public static GetLatestDingIndexResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLatestDingIndexResponseBody self = new GetLatestDingIndexResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLatestDingIndexResponseBody setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

    public GetLatestDingIndexResponseBody setIdxTotal(Float idxTotal) {
        this.idxTotal = idxTotal;
        return this;
    }
    public Float getIdxTotal() {
        return this.idxTotal;
    }

    public GetLatestDingIndexResponseBody setIdxEfficiency(Float idxEfficiency) {
        this.idxEfficiency = idxEfficiency;
        return this;
    }
    public Float getIdxEfficiency() {
        return this.idxEfficiency;
    }

    public GetLatestDingIndexResponseBody setIdxCarbon(Float idxCarbon) {
        this.idxCarbon = idxCarbon;
        return this;
    }
    public Float getIdxCarbon() {
        return this.idxCarbon;
    }

    public GetLatestDingIndexResponseBody setIdxMonthlyAvg(Float idxMonthlyAvg) {
        this.idxMonthlyAvg = idxMonthlyAvg;
        return this;
    }
    public Float getIdxMonthlyAvg() {
        return this.idxMonthlyAvg;
    }

}
