// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionCategoryStatisticsResponseBody extends TeaModel {
    /**
     * <p>统计明细</p>
     */
    @NameInMap("intentionCategoryRecords")
    public java.util.List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> intentionCategoryRecords;

    public static IntentionCategoryStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IntentionCategoryStatisticsResponseBody self = new IntentionCategoryStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public IntentionCategoryStatisticsResponseBody setIntentionCategoryRecords(java.util.List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> intentionCategoryRecords) {
        this.intentionCategoryRecords = intentionCategoryRecords;
        return this;
    }
    public java.util.List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> getIntentionCategoryRecords() {
        return this.intentionCategoryRecords;
    }

    public static class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords extends TeaModel {
        /**
         * <p>求助咨询量</p>
         */
        @NameInMap("askCount")
        public Long askCount;

        /**
         * <p>分类名</p>
         */
        @NameInMap("categoryName")
        public String categoryName;

        /**
         * <p>不满辱骂量</p>
         */
        @NameInMap("dissatisfiedCount")
        public Long dissatisfiedCount;

        /**
         * <p>产品异常量</p>
         */
        @NameInMap("errorCount")
        public Long errorCount;

        /**
         * <p>赞扬量</p>
         */
        @NameInMap("praiseCount")
        public Long praiseCount;

        /**
         * <p>产品建议量</p>
         */
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
