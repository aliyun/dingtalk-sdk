// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CategoryStatisticsResponseBody extends TeaModel {
    @NameInMap("categoryStatisticsRecords")
    public java.util.List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> categoryStatisticsRecords;

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
        @NameInMap("count")
        public Long count;

        @NameInMap("lastCount")
        public Long lastCount;

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
        @NameInMap("count")
        public Long count;

        @NameInMap("dt")
        public String dt;

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
