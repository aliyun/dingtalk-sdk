// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListDeviceRecordingDurationResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<ListDeviceRecordingDurationResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListDeviceRecordingDurationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeviceRecordingDurationResponseBody self = new ListDeviceRecordingDurationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeviceRecordingDurationResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDeviceRecordingDurationResponseBody setResult(java.util.List<ListDeviceRecordingDurationResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListDeviceRecordingDurationResponseBodyResult> getResult() {
        return this.result;
    }

    public ListDeviceRecordingDurationResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListDeviceRecordingDurationResponseBodyResult extends TeaModel {
        @NameInMap("duration")
        public String duration;

        @NameInMap("endTimestamp")
        public Long endTimestamp;

        @NameInMap("recordId")
        public String recordId;

        @NameInMap("startTimestamp")
        public Long startTimestamp;

        public static ListDeviceRecordingDurationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListDeviceRecordingDurationResponseBodyResult self = new ListDeviceRecordingDurationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListDeviceRecordingDurationResponseBodyResult setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public ListDeviceRecordingDurationResponseBodyResult setEndTimestamp(Long endTimestamp) {
            this.endTimestamp = endTimestamp;
            return this;
        }
        public Long getEndTimestamp() {
            return this.endTimestamp;
        }

        public ListDeviceRecordingDurationResponseBodyResult setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

        public ListDeviceRecordingDurationResponseBodyResult setStartTimestamp(Long startTimestamp) {
            this.startTimestamp = startTimestamp;
            return this;
        }
        public Long getStartTimestamp() {
            return this.startTimestamp;
        }

    }

}
