// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class OpenPeriodDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>311212121</p>
     */
    @NameInMap("endDate")
    public Long endDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2023</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FY_S1</p>
     */
    @NameInMap("periodBizType")
    public String periodBizType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8383838383</p>
     */
    @NameInMap("startDate")
    public Long startDate;

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

    public OpenPeriodDTO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public OpenPeriodDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenPeriodDTO setPeriodBizType(String periodBizType) {
        this.periodBizType = periodBizType;
        return this;
    }
    public String getPeriodBizType() {
        return this.periodBizType;
    }

    public OpenPeriodDTO setStartDate(Long startDate) {
        this.startDate = startDate;
        return this;
    }
    public Long getStartDate() {
        return this.startDate;
    }

}
