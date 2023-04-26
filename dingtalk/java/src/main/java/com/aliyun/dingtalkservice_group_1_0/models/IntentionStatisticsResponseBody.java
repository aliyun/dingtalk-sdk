// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionStatisticsResponseBody extends TeaModel {
    @NameInMap("intentionStatisticsRecords")
    public java.util.List<IntentionStatisticsResponseBodyIntentionStatisticsRecords> intentionStatisticsRecords;

    @NameInMap("intentionTrend")
    public java.util.List<IntentionStatisticsResponseBodyIntentionTrend> intentionTrend;

    public static IntentionStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IntentionStatisticsResponseBody self = new IntentionStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public IntentionStatisticsResponseBody setIntentionStatisticsRecords(java.util.List<IntentionStatisticsResponseBodyIntentionStatisticsRecords> intentionStatisticsRecords) {
        this.intentionStatisticsRecords = intentionStatisticsRecords;
        return this;
    }
    public java.util.List<IntentionStatisticsResponseBodyIntentionStatisticsRecords> getIntentionStatisticsRecords() {
        return this.intentionStatisticsRecords;
    }

    public IntentionStatisticsResponseBody setIntentionTrend(java.util.List<IntentionStatisticsResponseBodyIntentionTrend> intentionTrend) {
        this.intentionTrend = intentionTrend;
        return this;
    }
    public java.util.List<IntentionStatisticsResponseBodyIntentionTrend> getIntentionTrend() {
        return this.intentionTrend;
    }

    public static class IntentionStatisticsResponseBodyIntentionStatisticsRecords extends TeaModel {
        @NameInMap("count")
        public Long count;

        @NameInMap("intention")
        public String intention;

        @NameInMap("lastCount")
        public Long lastCount;

        public static IntentionStatisticsResponseBodyIntentionStatisticsRecords build(java.util.Map<String, ?> map) throws Exception {
            IntentionStatisticsResponseBodyIntentionStatisticsRecords self = new IntentionStatisticsResponseBodyIntentionStatisticsRecords();
            return TeaModel.build(map, self);
        }

        public IntentionStatisticsResponseBodyIntentionStatisticsRecords setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public IntentionStatisticsResponseBodyIntentionStatisticsRecords setIntention(String intention) {
            this.intention = intention;
            return this;
        }
        public String getIntention() {
            return this.intention;
        }

        public IntentionStatisticsResponseBodyIntentionStatisticsRecords setLastCount(Long lastCount) {
            this.lastCount = lastCount;
            return this;
        }
        public Long getLastCount() {
            return this.lastCount;
        }

    }

    public static class IntentionStatisticsResponseBodyIntentionTrend extends TeaModel {
        @NameInMap("count")
        public Long count;

        @NameInMap("dt")
        public String dt;

        @NameInMap("intention")
        public String intention;

        public static IntentionStatisticsResponseBodyIntentionTrend build(java.util.Map<String, ?> map) throws Exception {
            IntentionStatisticsResponseBodyIntentionTrend self = new IntentionStatisticsResponseBodyIntentionTrend();
            return TeaModel.build(map, self);
        }

        public IntentionStatisticsResponseBodyIntentionTrend setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public IntentionStatisticsResponseBodyIntentionTrend setDt(String dt) {
            this.dt = dt;
            return this;
        }
        public String getDt() {
            return this.dt;
        }

        public IntentionStatisticsResponseBodyIntentionTrend setIntention(String intention) {
            this.intention = intention;
            return this;
        }
        public String getIntention() {
            return this.intention;
        }

    }

}
