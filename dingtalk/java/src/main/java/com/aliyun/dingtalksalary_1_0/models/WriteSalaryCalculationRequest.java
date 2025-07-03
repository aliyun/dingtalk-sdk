// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class WriteSalaryCalculationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2025-06</p>
     */
    @NameInMap("date")
    public String date;

    @NameInMap("items")
    public java.util.List<WriteSalaryCalculationRequestItems> items;

    public static WriteSalaryCalculationRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteSalaryCalculationRequest self = new WriteSalaryCalculationRequest();
        return TeaModel.build(map, self);
    }

    public WriteSalaryCalculationRequest setDate(String date) {
        this.date = date;
        return this;
    }
    public String getDate() {
        return this.date;
    }

    public WriteSalaryCalculationRequest setItems(java.util.List<WriteSalaryCalculationRequestItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<WriteSalaryCalculationRequestItems> getItems() {
        return this.items;
    }

    public static class WriteSalaryCalculationRequestItemsContents extends TeaModel {
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

        public static WriteSalaryCalculationRequestItemsContents build(java.util.Map<String, ?> map) throws Exception {
            WriteSalaryCalculationRequestItemsContents self = new WriteSalaryCalculationRequestItemsContents();
            return TeaModel.build(map, self);
        }

        public WriteSalaryCalculationRequestItemsContents setSalaryItemId(String salaryItemId) {
            this.salaryItemId = salaryItemId;
            return this;
        }
        public String getSalaryItemId() {
            return this.salaryItemId;
        }

        public WriteSalaryCalculationRequestItemsContents setSalaryItemValue(String salaryItemValue) {
            this.salaryItemValue = salaryItemValue;
            return this;
        }
        public String getSalaryItemValue() {
            return this.salaryItemValue;
        }

    }

    public static class WriteSalaryCalculationRequestItems extends TeaModel {
        @NameInMap("contents")
        public java.util.List<WriteSalaryCalculationRequestItemsContents> contents;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user001</p>
         */
        @NameInMap("userId")
        public String userId;

        public static WriteSalaryCalculationRequestItems build(java.util.Map<String, ?> map) throws Exception {
            WriteSalaryCalculationRequestItems self = new WriteSalaryCalculationRequestItems();
            return TeaModel.build(map, self);
        }

        public WriteSalaryCalculationRequestItems setContents(java.util.List<WriteSalaryCalculationRequestItemsContents> contents) {
            this.contents = contents;
            return this;
        }
        public java.util.List<WriteSalaryCalculationRequestItemsContents> getContents() {
            return this.contents;
        }

        public WriteSalaryCalculationRequestItems setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
