// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveFinishResponseBody extends TeaModel {
    @NameInMap("result")
    public ProcessApproveFinishResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ProcessApproveFinishResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProcessApproveFinishResponseBody self = new ProcessApproveFinishResponseBody();
        return TeaModel.build(map, self);
    }

    public ProcessApproveFinishResponseBody setResult(ProcessApproveFinishResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ProcessApproveFinishResponseBodyResult getResult() {
        return this.result;
    }

    public ProcessApproveFinishResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ProcessApproveFinishResponseBodyResultDurationDetail extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2019-08-15</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>1.0</p>
         */
        @NameInMap("duration")
        public Double duration;

        public static ProcessApproveFinishResponseBodyResultDurationDetail build(java.util.Map<String, ?> map) throws Exception {
            ProcessApproveFinishResponseBodyResultDurationDetail self = new ProcessApproveFinishResponseBodyResultDurationDetail();
            return TeaModel.build(map, self);
        }

        public ProcessApproveFinishResponseBodyResultDurationDetail setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ProcessApproveFinishResponseBodyResultDurationDetail setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

    }

    public static class ProcessApproveFinishResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2.0</p>
         */
        @NameInMap("duration")
        public Double duration;

        @NameInMap("durationDetail")
        public java.util.List<ProcessApproveFinishResponseBodyResultDurationDetail> durationDetail;

        public static ProcessApproveFinishResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ProcessApproveFinishResponseBodyResult self = new ProcessApproveFinishResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ProcessApproveFinishResponseBodyResult setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public ProcessApproveFinishResponseBodyResult setDurationDetail(java.util.List<ProcessApproveFinishResponseBodyResultDurationDetail> durationDetail) {
            this.durationDetail = durationDetail;
            return this;
        }
        public java.util.List<ProcessApproveFinishResponseBodyResultDurationDetail> getDurationDetail() {
            return this.durationDetail;
        }

    }

}
