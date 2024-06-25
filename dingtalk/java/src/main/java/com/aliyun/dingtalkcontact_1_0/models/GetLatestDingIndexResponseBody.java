// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetLatestDingIndexResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("idxCarbon")
    public Float idxCarbon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("idxEfficiency")
    public Float idxEfficiency;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>888</p>
     */
    @NameInMap("idxMonthlyAvg")
    public Float idxMonthlyAvg;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>888</p>
     */
    @NameInMap("idxTotal")
    public Float idxTotal;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20210412</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static GetLatestDingIndexResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLatestDingIndexResponseBody self = new GetLatestDingIndexResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLatestDingIndexResponseBody setIdxCarbon(Float idxCarbon) {
        this.idxCarbon = idxCarbon;
        return this;
    }
    public Float getIdxCarbon() {
        return this.idxCarbon;
    }

    public GetLatestDingIndexResponseBody setIdxEfficiency(Float idxEfficiency) {
        this.idxEfficiency = idxEfficiency;
        return this;
    }
    public Float getIdxEfficiency() {
        return this.idxEfficiency;
    }

    public GetLatestDingIndexResponseBody setIdxMonthlyAvg(Float idxMonthlyAvg) {
        this.idxMonthlyAvg = idxMonthlyAvg;
        return this;
    }
    public Float getIdxMonthlyAvg() {
        return this.idxMonthlyAvg;
    }

    public GetLatestDingIndexResponseBody setIdxTotal(Float idxTotal) {
        this.idxTotal = idxTotal;
        return this;
    }
    public Float getIdxTotal() {
        return this.idxTotal;
    }

    public GetLatestDingIndexResponseBody setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
