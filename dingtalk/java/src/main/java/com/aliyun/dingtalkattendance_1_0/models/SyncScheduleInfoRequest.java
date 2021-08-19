// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SyncScheduleInfoRequest extends TeaModel {
    @NameInMap("scheduleInfos")
    public java.util.List<SyncScheduleInfoRequestScheduleInfos> scheduleInfos;

    @NameInMap("opUserId")
    public String opUserId;

    public static SyncScheduleInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncScheduleInfoRequest self = new SyncScheduleInfoRequest();
        return TeaModel.build(map, self);
    }

    public SyncScheduleInfoRequest setScheduleInfos(java.util.List<SyncScheduleInfoRequestScheduleInfos> scheduleInfos) {
        this.scheduleInfos = scheduleInfos;
        return this;
    }
    public java.util.List<SyncScheduleInfoRequestScheduleInfos> getScheduleInfos() {
        return this.scheduleInfos;
    }

    public SyncScheduleInfoRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class SyncScheduleInfoRequestScheduleInfos extends TeaModel {
        @NameInMap("planId")
        public Long planId;

        @NameInMap("wifiKeys")
        public java.util.List<String> wifiKeys;

        @NameInMap("positionKeys")
        public java.util.List<String> positionKeys;

        public static SyncScheduleInfoRequestScheduleInfos build(java.util.Map<String, ?> map) throws Exception {
            SyncScheduleInfoRequestScheduleInfos self = new SyncScheduleInfoRequestScheduleInfos();
            return TeaModel.build(map, self);
        }

        public SyncScheduleInfoRequestScheduleInfos setPlanId(Long planId) {
            this.planId = planId;
            return this;
        }
        public Long getPlanId() {
            return this.planId;
        }

        public SyncScheduleInfoRequestScheduleInfos setWifiKeys(java.util.List<String> wifiKeys) {
            this.wifiKeys = wifiKeys;
            return this;
        }
        public java.util.List<String> getWifiKeys() {
            return this.wifiKeys;
        }

        public SyncScheduleInfoRequestScheduleInfos setPositionKeys(java.util.List<String> positionKeys) {
            this.positionKeys = positionKeys;
            return this;
        }
        public java.util.List<String> getPositionKeys() {
            return this.positionKeys;
        }

    }

}
