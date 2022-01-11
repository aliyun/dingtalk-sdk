// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckClosingAccountRequest extends TeaModel {
    // 情景
    @NameInMap("bizCode")
    public String bizCode;

    // 员工列表
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    // 时间段
    @NameInMap("userTimeRange")
    public java.util.List<CheckClosingAccountRequestUserTimeRange> userTimeRange;

    public static CheckClosingAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckClosingAccountRequest self = new CheckClosingAccountRequest();
        return TeaModel.build(map, self);
    }

    public CheckClosingAccountRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public CheckClosingAccountRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public CheckClosingAccountRequest setUserTimeRange(java.util.List<CheckClosingAccountRequestUserTimeRange> userTimeRange) {
        this.userTimeRange = userTimeRange;
        return this;
    }
    public java.util.List<CheckClosingAccountRequestUserTimeRange> getUserTimeRange() {
        return this.userTimeRange;
    }

    public static class CheckClosingAccountRequestUserTimeRange extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("startTime")
        public Long startTime;

        public static CheckClosingAccountRequestUserTimeRange build(java.util.Map<String, ?> map) throws Exception {
            CheckClosingAccountRequestUserTimeRange self = new CheckClosingAccountRequestUserTimeRange();
            return TeaModel.build(map, self);
        }

        public CheckClosingAccountRequestUserTimeRange setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public CheckClosingAccountRequestUserTimeRange setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

}
