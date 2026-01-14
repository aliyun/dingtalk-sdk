// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListServiceRecordResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<ListServiceRecordResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListServiceRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListServiceRecordResponseBody self = new ListServiceRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public ListServiceRecordResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListServiceRecordResponseBody setResult(java.util.List<ListServiceRecordResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListServiceRecordResponseBodyResult> getResult() {
        return this.result;
    }

    public ListServiceRecordResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListServiceRecordResponseBodyResultTeam extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static ListServiceRecordResponseBodyResultTeam build(java.util.Map<String, ?> map) throws Exception {
            ListServiceRecordResponseBodyResultTeam self = new ListServiceRecordResponseBodyResultTeam();
            return TeaModel.build(map, self);
        }

        public ListServiceRecordResponseBodyResultTeam setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public ListServiceRecordResponseBodyResultTeam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListServiceRecordResponseBodyResultUser extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListServiceRecordResponseBodyResultUser build(java.util.Map<String, ?> map) throws Exception {
            ListServiceRecordResponseBodyResultUser self = new ListServiceRecordResponseBodyResultUser();
            return TeaModel.build(map, self);
        }

        public ListServiceRecordResponseBodyResultUser setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListServiceRecordResponseBodyResultUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListServiceRecordResponseBodyResult extends TeaModel {
        @NameInMap("customerId")
        public String customerId;

        @NameInMap("deviceSn")
        public String deviceSn;

        @NameInMap("duration")
        public String duration;

        @NameInMap("endTimestamp")
        public Long endTimestamp;

        @NameInMap("recordId")
        public String recordId;

        @NameInMap("startTimestamp")
        public Long startTimestamp;

        @NameInMap("team")
        public ListServiceRecordResponseBodyResultTeam team;

        @NameInMap("user")
        public ListServiceRecordResponseBodyResultUser user;

        public static ListServiceRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListServiceRecordResponseBodyResult self = new ListServiceRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListServiceRecordResponseBodyResult setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

        public ListServiceRecordResponseBodyResult setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public ListServiceRecordResponseBodyResult setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public ListServiceRecordResponseBodyResult setEndTimestamp(Long endTimestamp) {
            this.endTimestamp = endTimestamp;
            return this;
        }
        public Long getEndTimestamp() {
            return this.endTimestamp;
        }

        public ListServiceRecordResponseBodyResult setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

        public ListServiceRecordResponseBodyResult setStartTimestamp(Long startTimestamp) {
            this.startTimestamp = startTimestamp;
            return this;
        }
        public Long getStartTimestamp() {
            return this.startTimestamp;
        }

        public ListServiceRecordResponseBodyResult setTeam(ListServiceRecordResponseBodyResultTeam team) {
            this.team = team;
            return this;
        }
        public ListServiceRecordResponseBodyResultTeam getTeam() {
            return this.team;
        }

        public ListServiceRecordResponseBodyResult setUser(ListServiceRecordResponseBodyResultUser user) {
            this.user = user;
            return this;
        }
        public ListServiceRecordResponseBodyResultUser getUser() {
            return this.user;
        }

    }

}
