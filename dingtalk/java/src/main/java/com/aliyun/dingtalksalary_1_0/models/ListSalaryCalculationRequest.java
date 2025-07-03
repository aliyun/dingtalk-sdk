// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class ListSalaryCalculationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2025-06</p>
     */
    @NameInMap("date")
    public String date;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageIndex")
    public Integer pageIndex;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SalaryGroupXXX</p>
     */
    @NameInMap("salaryGroupId")
    public String salaryGroupId;

    public static ListSalaryCalculationRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSalaryCalculationRequest self = new ListSalaryCalculationRequest();
        return TeaModel.build(map, self);
    }

    public ListSalaryCalculationRequest setDate(String date) {
        this.date = date;
        return this;
    }
    public String getDate() {
        return this.date;
    }

    public ListSalaryCalculationRequest setPageIndex(Integer pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Integer getPageIndex() {
        return this.pageIndex;
    }

    public ListSalaryCalculationRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListSalaryCalculationRequest setSalaryGroupId(String salaryGroupId) {
        this.salaryGroupId = salaryGroupId;
        return this;
    }
    public String getSalaryGroupId() {
        return this.salaryGroupId;
    }

}
