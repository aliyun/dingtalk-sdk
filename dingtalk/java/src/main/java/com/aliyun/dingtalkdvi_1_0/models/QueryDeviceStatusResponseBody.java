// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryDeviceStatusResponseBodyResult> result;

    public static QueryDeviceStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceStatusResponseBody self = new QueryDeviceStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceStatusResponseBody setResult(java.util.List<QueryDeviceStatusResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryDeviceStatusResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryDeviceStatusResponseBodyResultBattery extends TeaModel {
        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("value")
        public Integer value;

        public static QueryDeviceStatusResponseBodyResultBattery build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceStatusResponseBodyResultBattery self = new QueryDeviceStatusResponseBodyResultBattery();
            return TeaModel.build(map, self);
        }

        public QueryDeviceStatusResponseBodyResultBattery setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public QueryDeviceStatusResponseBodyResultBattery setValue(Integer value) {
            this.value = value;
            return this;
        }
        public Integer getValue() {
            return this.value;
        }

    }

    public static class QueryDeviceStatusResponseBodyResultFirmware extends TeaModel {
        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("value")
        public String value;

        public static QueryDeviceStatusResponseBodyResultFirmware build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceStatusResponseBodyResultFirmware self = new QueryDeviceStatusResponseBodyResultFirmware();
            return TeaModel.build(map, self);
        }

        public QueryDeviceStatusResponseBodyResultFirmware setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public QueryDeviceStatusResponseBodyResultFirmware setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryDeviceStatusResponseBodyResultRecordingStartTime extends TeaModel {
        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("value")
        public Long value;

        public static QueryDeviceStatusResponseBodyResultRecordingStartTime build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceStatusResponseBodyResultRecordingStartTime self = new QueryDeviceStatusResponseBodyResultRecordingStartTime();
            return TeaModel.build(map, self);
        }

        public QueryDeviceStatusResponseBodyResultRecordingStartTime setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public QueryDeviceStatusResponseBodyResultRecordingStartTime setValue(Long value) {
            this.value = value;
            return this;
        }
        public Long getValue() {
            return this.value;
        }

    }

    public static class QueryDeviceStatusResponseBodyResultStatus extends TeaModel {
        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("value")
        public String value;

        public static QueryDeviceStatusResponseBodyResultStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceStatusResponseBodyResultStatus self = new QueryDeviceStatusResponseBodyResultStatus();
            return TeaModel.build(map, self);
        }

        public QueryDeviceStatusResponseBodyResultStatus setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public QueryDeviceStatusResponseBodyResultStatus setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryDeviceStatusResponseBodyResult extends TeaModel {
        @NameInMap("battery")
        public QueryDeviceStatusResponseBodyResultBattery battery;

        @NameInMap("firmware")
        public QueryDeviceStatusResponseBodyResultFirmware firmware;

        @NameInMap("recordingStartTime")
        public QueryDeviceStatusResponseBodyResultRecordingStartTime recordingStartTime;

        @NameInMap("sn")
        public String sn;

        @NameInMap("status")
        public QueryDeviceStatusResponseBodyResultStatus status;

        public static QueryDeviceStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceStatusResponseBodyResult self = new QueryDeviceStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDeviceStatusResponseBodyResult setBattery(QueryDeviceStatusResponseBodyResultBattery battery) {
            this.battery = battery;
            return this;
        }
        public QueryDeviceStatusResponseBodyResultBattery getBattery() {
            return this.battery;
        }

        public QueryDeviceStatusResponseBodyResult setFirmware(QueryDeviceStatusResponseBodyResultFirmware firmware) {
            this.firmware = firmware;
            return this;
        }
        public QueryDeviceStatusResponseBodyResultFirmware getFirmware() {
            return this.firmware;
        }

        public QueryDeviceStatusResponseBodyResult setRecordingStartTime(QueryDeviceStatusResponseBodyResultRecordingStartTime recordingStartTime) {
            this.recordingStartTime = recordingStartTime;
            return this;
        }
        public QueryDeviceStatusResponseBodyResultRecordingStartTime getRecordingStartTime() {
            return this.recordingStartTime;
        }

        public QueryDeviceStatusResponseBodyResult setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public QueryDeviceStatusResponseBodyResult setStatus(QueryDeviceStatusResponseBodyResultStatus status) {
            this.status = status;
            return this;
        }
        public QueryDeviceStatusResponseBodyResultStatus getStatus() {
            return this.status;
        }

    }

}
