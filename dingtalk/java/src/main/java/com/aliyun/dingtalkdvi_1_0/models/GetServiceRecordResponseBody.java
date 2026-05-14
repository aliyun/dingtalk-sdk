// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public GetServiceRecordResponseBodyResult result;

    public static GetServiceRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRecordResponseBody self = new GetServiceRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetServiceRecordResponseBody setResult(GetServiceRecordResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetServiceRecordResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetServiceRecordResponseBodyResultTeam extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetServiceRecordResponseBodyResultTeam build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordResponseBodyResultTeam self = new GetServiceRecordResponseBodyResultTeam();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordResponseBodyResultTeam setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetServiceRecordResponseBodyResultTeam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetServiceRecordResponseBodyResultUser extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetServiceRecordResponseBodyResultUser build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordResponseBodyResultUser self = new GetServiceRecordResponseBodyResultUser();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordResponseBodyResultUser setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetServiceRecordResponseBodyResultUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetServiceRecordResponseBodyResult extends TeaModel {
        @NameInMap("customerId")
        public String customerId;

        @NameInMap("deviceSn")
        public String deviceSn;

        @NameInMap("duration")
        public String duration;

        @NameInMap("endTimestamp")
        public Long endTimestamp;

        @NameInMap("outBizData")
        public String outBizData;

        @NameInMap("qualityInspectionScore")
        public Integer qualityInspectionScore;

        @NameInMap("recordId")
        public String recordId;

        @NameInMap("startTimestamp")
        public Long startTimestamp;

        @NameInMap("team")
        public GetServiceRecordResponseBodyResultTeam team;

        @NameInMap("user")
        public GetServiceRecordResponseBodyResultUser user;

        @NameInMap("valid")
        public Boolean valid;

        public static GetServiceRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordResponseBodyResult self = new GetServiceRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordResponseBodyResult setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

        public GetServiceRecordResponseBodyResult setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public GetServiceRecordResponseBodyResult setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public GetServiceRecordResponseBodyResult setEndTimestamp(Long endTimestamp) {
            this.endTimestamp = endTimestamp;
            return this;
        }
        public Long getEndTimestamp() {
            return this.endTimestamp;
        }

        public GetServiceRecordResponseBodyResult setOutBizData(String outBizData) {
            this.outBizData = outBizData;
            return this;
        }
        public String getOutBizData() {
            return this.outBizData;
        }

        public GetServiceRecordResponseBodyResult setQualityInspectionScore(Integer qualityInspectionScore) {
            this.qualityInspectionScore = qualityInspectionScore;
            return this;
        }
        public Integer getQualityInspectionScore() {
            return this.qualityInspectionScore;
        }

        public GetServiceRecordResponseBodyResult setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

        public GetServiceRecordResponseBodyResult setStartTimestamp(Long startTimestamp) {
            this.startTimestamp = startTimestamp;
            return this;
        }
        public Long getStartTimestamp() {
            return this.startTimestamp;
        }

        public GetServiceRecordResponseBodyResult setTeam(GetServiceRecordResponseBodyResultTeam team) {
            this.team = team;
            return this;
        }
        public GetServiceRecordResponseBodyResultTeam getTeam() {
            return this.team;
        }

        public GetServiceRecordResponseBodyResult setUser(GetServiceRecordResponseBodyResultUser user) {
            this.user = user;
            return this;
        }
        public GetServiceRecordResponseBodyResultUser getUser() {
            return this.user;
        }

        public GetServiceRecordResponseBodyResult setValid(Boolean valid) {
            this.valid = valid;
            return this;
        }
        public Boolean getValid() {
            return this.valid;
        }

    }

}
