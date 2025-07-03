// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class ListSalaryCalculationResponseBody extends TeaModel {
    @NameInMap("result")
    public ListSalaryCalculationResponseBodyResult result;

    public static ListSalaryCalculationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSalaryCalculationResponseBody self = new ListSalaryCalculationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSalaryCalculationResponseBody setResult(ListSalaryCalculationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListSalaryCalculationResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListSalaryCalculationResponseBodyResultDataDataList extends TeaModel {
        @NameInMap("salaryItemId")
        public String salaryItemId;

        @NameInMap("salaryItemName")
        public String salaryItemName;

        @NameInMap("salaryItemValue")
        public String salaryItemValue;

        public static ListSalaryCalculationResponseBodyResultDataDataList build(java.util.Map<String, ?> map) throws Exception {
            ListSalaryCalculationResponseBodyResultDataDataList self = new ListSalaryCalculationResponseBodyResultDataDataList();
            return TeaModel.build(map, self);
        }

        public ListSalaryCalculationResponseBodyResultDataDataList setSalaryItemId(String salaryItemId) {
            this.salaryItemId = salaryItemId;
            return this;
        }
        public String getSalaryItemId() {
            return this.salaryItemId;
        }

        public ListSalaryCalculationResponseBodyResultDataDataList setSalaryItemName(String salaryItemName) {
            this.salaryItemName = salaryItemName;
            return this;
        }
        public String getSalaryItemName() {
            return this.salaryItemName;
        }

        public ListSalaryCalculationResponseBodyResultDataDataList setSalaryItemValue(String salaryItemValue) {
            this.salaryItemValue = salaryItemValue;
            return this;
        }
        public String getSalaryItemValue() {
            return this.salaryItemValue;
        }

    }

    public static class ListSalaryCalculationResponseBodyResultData extends TeaModel {
        @NameInMap("dataList")
        public java.util.List<ListSalaryCalculationResponseBodyResultDataDataList> dataList;

        @NameInMap("userId")
        public String userId;

        public static ListSalaryCalculationResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            ListSalaryCalculationResponseBodyResultData self = new ListSalaryCalculationResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public ListSalaryCalculationResponseBodyResultData setDataList(java.util.List<ListSalaryCalculationResponseBodyResultDataDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<ListSalaryCalculationResponseBodyResultDataDataList> getDataList() {
            return this.dataList;
        }

        public ListSalaryCalculationResponseBodyResultData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListSalaryCalculationResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<ListSalaryCalculationResponseBodyResultData> data;

        @NameInMap("hasMore")
        public Boolean hasMore;

        public static ListSalaryCalculationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListSalaryCalculationResponseBodyResult self = new ListSalaryCalculationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListSalaryCalculationResponseBodyResult setData(java.util.List<ListSalaryCalculationResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<ListSalaryCalculationResponseBodyResultData> getData() {
            return this.data;
        }

        public ListSalaryCalculationResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

    }

}
