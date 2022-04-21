// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TopicStatisticsResponseBody extends TeaModel {
    // 话题趋势
    @NameInMap("topicStatisticsRecords")
    public java.util.List<TopicStatisticsResponseBodyTopicStatisticsRecords> topicStatisticsRecords;

    public static TopicStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TopicStatisticsResponseBody self = new TopicStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public TopicStatisticsResponseBody setTopicStatisticsRecords(java.util.List<TopicStatisticsResponseBodyTopicStatisticsRecords> topicStatisticsRecords) {
        this.topicStatisticsRecords = topicStatisticsRecords;
        return this;
    }
    public java.util.List<TopicStatisticsResponseBodyTopicStatisticsRecords> getTopicStatisticsRecords() {
        return this.topicStatisticsRecords;
    }

    public static class TopicStatisticsResponseBodyTopicStatisticsRecords extends TeaModel {
        // 日期
        @NameInMap("dt")
        public String dt;

        // 消息量
        @NameInMap("msgCount")
        public Long msgCount;

        // 参与人数
        @NameInMap("participantsNum")
        public Long participantsNum;

        // 话题数量
        @NameInMap("topicNum")
        public Long topicNum;

        public static TopicStatisticsResponseBodyTopicStatisticsRecords build(java.util.Map<String, ?> map) throws Exception {
            TopicStatisticsResponseBodyTopicStatisticsRecords self = new TopicStatisticsResponseBodyTopicStatisticsRecords();
            return TeaModel.build(map, self);
        }

        public TopicStatisticsResponseBodyTopicStatisticsRecords setDt(String dt) {
            this.dt = dt;
            return this;
        }
        public String getDt() {
            return this.dt;
        }

        public TopicStatisticsResponseBodyTopicStatisticsRecords setMsgCount(Long msgCount) {
            this.msgCount = msgCount;
            return this;
        }
        public Long getMsgCount() {
            return this.msgCount;
        }

        public TopicStatisticsResponseBodyTopicStatisticsRecords setParticipantsNum(Long participantsNum) {
            this.participantsNum = participantsNum;
            return this;
        }
        public Long getParticipantsNum() {
            return this.participantsNum;
        }

        public TopicStatisticsResponseBodyTopicStatisticsRecords setTopicNum(Long topicNum) {
            this.topicNum = topicNum;
            return this;
        }
        public Long getTopicNum() {
            return this.topicNum;
        }

    }

}
