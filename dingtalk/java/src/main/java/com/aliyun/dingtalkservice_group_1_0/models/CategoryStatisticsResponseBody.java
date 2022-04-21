// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CategoryStatisticsResponseBody extends TeaModel {
    // 分类统计
    @NameInMap("categoryStatisticsRecords")
    public java.util.List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> categoryStatisticsRecords;

    // 分类趋势
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
        // 心声数量
        @NameInMap("count")
        public Long count;

        // 上期心声数量
        @NameInMap("lastCount")
        public Long lastCount;

        // 分类名称
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
        // 心声数量
        @NameInMap("count")
        public Long count;

        // 日期
        @NameInMap("dt")
        public String dt;

        // 分类名称
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

    public static class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords extends TeaModel {
        // 求助咨询量
        @NameInMap("askCount")
        public Long askCount;

        // 分类名
        @NameInMap("categoryName")
        public String categoryName;

        // 不满辱骂量
        @NameInMap("dissatisfiedCount")
        public Long dissatisfiedCount;

        // 产品异常量
        @NameInMap("errorCount")
        public Long errorCount;

        // 赞扬量
        @NameInMap("praiseCount")
        public Long praiseCount;

        // 产品建议量
        @NameInMap("suggestCount")
        public Long suggestCount;

        public static IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords build(java.util.Map<String, ?> map) throws Exception {
            IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords self = new IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords();
            return TeaModel.build(map, self);
        }

        public IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords setAskCount(Long askCount) {
            this.askCount = askCount;
            return this;
        }
        public Long getAskCount() {
            return this.askCount;
        }

        public IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords setDissatisfiedCount(Long dissatisfiedCount) {
            this.dissatisfiedCount = dissatisfiedCount;
            return this;
        }
        public Long getDissatisfiedCount() {
            return this.dissatisfiedCount;
        }

        public IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords setErrorCount(Long errorCount) {
            this.errorCount = errorCount;
            return this;
        }
        public Long getErrorCount() {
            return this.errorCount;
        }

        public IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords setPraiseCount(Long praiseCount) {
            this.praiseCount = praiseCount;
            return this;
        }
        public Long getPraiseCount() {
            return this.praiseCount;
        }

        public IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords setSuggestCount(Long suggestCount) {
            this.suggestCount = suggestCount;
            return this;
        }
        public Long getSuggestCount() {
            return this.suggestCount;
        }

    }

}
