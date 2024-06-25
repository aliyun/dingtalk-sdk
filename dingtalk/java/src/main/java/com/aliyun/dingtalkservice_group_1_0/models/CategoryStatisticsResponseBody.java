// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CategoryStatisticsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("categoryStatisticsRecords")
    public java.util.List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> categoryStatisticsRecords;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("categoryTrend")
    public java.util.List<CategoryStatisticsResponseBodyCategoryTrend> categoryTrend;

    public static CategoryStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CategoryStatisticsResponseBody self = new CategoryStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public CategoryStatisticsResponseBody setCategoryStatisticsRecords(java.util.List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> categoryStatisticsRecords) {
        this.categoryStatisticsRecords = categoryStatisticsRecords;
        return this;
    }
    public java.util.List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> getCategoryStatisticsRecords() {
        return this.categoryStatisticsRecords;
    }

    public CategoryStatisticsResponseBody setCategoryTrend(java.util.List<CategoryStatisticsResponseBodyCategoryTrend> categoryTrend) {
        this.categoryTrend = categoryTrend;
        return this;
    }
    public java.util.List<CategoryStatisticsResponseBodyCategoryTrend> getCategoryTrend() {
        return this.categoryTrend;
    }

    public static class CategoryStatisticsResponseBodyCategoryStatisticsRecords extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("count")
        public Long count;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>9</p>
         */
        @NameInMap("lastCount")
        public Long lastCount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>工单类</p>
         */
        @NameInMap("name")
        public String name;

        public static CategoryStatisticsResponseBodyCategoryStatisticsRecords build(java.util.Map<String, ?> map) throws Exception {
            CategoryStatisticsResponseBodyCategoryStatisticsRecords self = new CategoryStatisticsResponseBodyCategoryStatisticsRecords();
            return TeaModel.build(map, self);
        }

        public CategoryStatisticsResponseBodyCategoryStatisticsRecords setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public CategoryStatisticsResponseBodyCategoryStatisticsRecords setLastCount(Long lastCount) {
            this.lastCount = lastCount;
            return this;
        }
        public Long getLastCount() {
            return this.lastCount;
        }

        public CategoryStatisticsResponseBodyCategoryStatisticsRecords setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CategoryStatisticsResponseBodyCategoryTrend extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("count")
        public Long count;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20220101</p>
         */
        @NameInMap("dt")
        public String dt;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>工单类</p>
         */
        @NameInMap("name")
        public String name;

        public static CategoryStatisticsResponseBodyCategoryTrend build(java.util.Map<String, ?> map) throws Exception {
            CategoryStatisticsResponseBodyCategoryTrend self = new CategoryStatisticsResponseBodyCategoryTrend();
            return TeaModel.build(map, self);
        }

        public CategoryStatisticsResponseBodyCategoryTrend setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public CategoryStatisticsResponseBodyCategoryTrend setDt(String dt) {
            this.dt = dt;
            return this;
        }
        public String getDt() {
            return this.dt;
        }

        public CategoryStatisticsResponseBodyCategoryTrend setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
