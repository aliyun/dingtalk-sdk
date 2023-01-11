// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GroupStatisticsResponseBody extends TeaModel {
    /**
     * <p>(本期)群总数</p>
     */
    @NameInMap("groupCount")
    public Long groupCount;

    /**
     * <p>群趋势</p>
     */
    @NameInMap("groupTrend")
    public java.util.List<GroupStatisticsResponseBodyGroupTrend> groupTrend;

    /**
     * <p>较上期增长数</p>
     */
    @NameInMap("increaseGroupCount")
    public Long increaseGroupCount;

    /**
     * <p>较上期增长率(已乘以100）</p>
     */
    @NameInMap("increaseRate")
    public String increaseRate;

    public static GroupStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupStatisticsResponseBody self = new GroupStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupStatisticsResponseBody setGroupCount(Long groupCount) {
        this.groupCount = groupCount;
        return this;
    }
    public Long getGroupCount() {
        return this.groupCount;
    }

    public GroupStatisticsResponseBody setGroupTrend(java.util.List<GroupStatisticsResponseBodyGroupTrend> groupTrend) {
        this.groupTrend = groupTrend;
        return this;
    }
    public java.util.List<GroupStatisticsResponseBodyGroupTrend> getGroupTrend() {
        return this.groupTrend;
    }

    public GroupStatisticsResponseBody setIncreaseGroupCount(Long increaseGroupCount) {
        this.increaseGroupCount = increaseGroupCount;
        return this;
    }
    public Long getIncreaseGroupCount() {
        return this.increaseGroupCount;
    }

    public GroupStatisticsResponseBody setIncreaseRate(String increaseRate) {
        this.increaseRate = increaseRate;
        return this;
    }
    public String getIncreaseRate() {
        return this.increaseRate;
    }

    public static class GroupStatisticsResponseBodyGroupTrend extends TeaModel {
        /**
         * <p>群数量</p>
         */
        @NameInMap("count")
        public Long count;

        /**
         * <p>日期</p>
         */
        @NameInMap("dt")
        public String dt;

        public static GroupStatisticsResponseBodyGroupTrend build(java.util.Map<String, ?> map) throws Exception {
            GroupStatisticsResponseBodyGroupTrend self = new GroupStatisticsResponseBodyGroupTrend();
            return TeaModel.build(map, self);
        }

        public GroupStatisticsResponseBodyGroupTrend setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public GroupStatisticsResponseBodyGroupTrend setDt(String dt) {
            this.dt = dt;
            return this;
        }
        public String getDt() {
            return this.dt;
        }

    }

}
