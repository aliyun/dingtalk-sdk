// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CalculateDurationResponseBody extends TeaModel {
    @NameInMap("result")
    public CalculateDurationResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CalculateDurationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CalculateDurationResponseBody self = new CalculateDurationResponseBody();
        return TeaModel.build(map, self);
    }

    public CalculateDurationResponseBody setResult(CalculateDurationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CalculateDurationResponseBodyResult getResult() {
        return this.result;
    }

    public CalculateDurationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CalculateDurationResponseBodyResultDurationDetail extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("duration")
        public Double duration;

        public static CalculateDurationResponseBodyResultDurationDetail build(java.util.Map<String, ?> map) throws Exception {
            CalculateDurationResponseBodyResultDurationDetail self = new CalculateDurationResponseBodyResultDurationDetail();
            return TeaModel.build(map, self);
        }

        public CalculateDurationResponseBodyResultDurationDetail setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CalculateDurationResponseBodyResultDurationDetail setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

    }

    public static class CalculateDurationResponseBodyResult extends TeaModel {
        @NameInMap("duration")
        public Double duration;

        @NameInMap("durationDetail")
        public java.util.List<CalculateDurationResponseBodyResultDurationDetail> durationDetail;

        public static CalculateDurationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CalculateDurationResponseBodyResult self = new CalculateDurationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CalculateDurationResponseBodyResult setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public CalculateDurationResponseBodyResult setDurationDetail(java.util.List<CalculateDurationResponseBodyResultDurationDetail> durationDetail) {
            this.durationDetail = durationDetail;
            return this;
        }
        public java.util.List<CalculateDurationResponseBodyResultDurationDetail> getDurationDetail() {
            return this.durationDetail;
        }

    }

}
