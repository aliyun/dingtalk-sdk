// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class SaveSalaryArchivesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>转正</p>
     */
    @NameInMap("adjustMemo")
    public String adjustMemo;

    @NameInMap("contents")
    public java.util.List<SaveSalaryArchivesRequestContents> contents;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2025-06-01</p>
     */
    @NameInMap("effectiveDate")
    public String effectiveDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user001</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user001</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SaveSalaryArchivesRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveSalaryArchivesRequest self = new SaveSalaryArchivesRequest();
        return TeaModel.build(map, self);
    }

    public SaveSalaryArchivesRequest setAdjustMemo(String adjustMemo) {
        this.adjustMemo = adjustMemo;
        return this;
    }
    public String getAdjustMemo() {
        return this.adjustMemo;
    }

    public SaveSalaryArchivesRequest setContents(java.util.List<SaveSalaryArchivesRequestContents> contents) {
        this.contents = contents;
        return this;
    }
    public java.util.List<SaveSalaryArchivesRequestContents> getContents() {
        return this.contents;
    }

    public SaveSalaryArchivesRequest setEffectiveDate(String effectiveDate) {
        this.effectiveDate = effectiveDate;
        return this;
    }
    public String getEffectiveDate() {
        return this.effectiveDate;
    }

    public SaveSalaryArchivesRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public SaveSalaryArchivesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SaveSalaryArchivesRequestContents extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>SalaryItemXXX</p>
         */
        @NameInMap("salaryItemId")
        public String salaryItemId;

        /**
         * <strong>example:</strong>
         * <p>26</p>
         */
        @NameInMap("salaryItemValue")
        public String salaryItemValue;

        public static SaveSalaryArchivesRequestContents build(java.util.Map<String, ?> map) throws Exception {
            SaveSalaryArchivesRequestContents self = new SaveSalaryArchivesRequestContents();
            return TeaModel.build(map, self);
        }

        public SaveSalaryArchivesRequestContents setSalaryItemId(String salaryItemId) {
            this.salaryItemId = salaryItemId;
            return this;
        }
        public String getSalaryItemId() {
            return this.salaryItemId;
        }

        public SaveSalaryArchivesRequestContents setSalaryItemValue(String salaryItemValue) {
            this.salaryItemValue = salaryItemValue;
            return this;
        }
        public String getSalaryItemValue() {
            return this.salaryItemValue;
        }

    }

}
