// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenPeriodDTO extends TeaModel {
    @NameInMap("endDate")
    public Long endDate;

    @NameInMap("nameCn")
    public String nameCn;

    @NameInMap("nameEn")
    public String nameEn;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("periodId")
    public String periodId;

    @NameInMap("startDate")
    public Long startDate;

    @NameInMap("status")
    public Integer status;

    public static OpenPeriodDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenPeriodDTO self = new OpenPeriodDTO();
        return TeaModel.build(map, self);
    }

    public OpenPeriodDTO setEndDate(Long endDate) {
        this.endDate = endDate;
        return this;
    }
    public Long getEndDate() {
        return this.endDate;
    }

    public OpenPeriodDTO setNameCn(String nameCn) {
        this.nameCn = nameCn;
        return this;
    }
    public String getNameCn() {
        return this.nameCn;
    }

    public OpenPeriodDTO setNameEn(String nameEn) {
        this.nameEn = nameEn;
        return this;
    }
    public String getNameEn() {
        return this.nameEn;
    }

    public OpenPeriodDTO setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public OpenPeriodDTO setStartDate(Long startDate) {
        this.startDate = startDate;
        return this;
    }
    public Long getStartDate() {
        return this.startDate;
    }

    public OpenPeriodDTO setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
