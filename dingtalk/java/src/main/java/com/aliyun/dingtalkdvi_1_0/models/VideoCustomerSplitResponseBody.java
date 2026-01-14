// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class VideoCustomerSplitResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public VideoCustomerSplitResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static VideoCustomerSplitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        VideoCustomerSplitResponseBody self = new VideoCustomerSplitResponseBody();
        return TeaModel.build(map, self);
    }

    public VideoCustomerSplitResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public VideoCustomerSplitResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public VideoCustomerSplitResponseBody setResult(VideoCustomerSplitResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public VideoCustomerSplitResponseBodyResult getResult() {
        return this.result;
    }

    public VideoCustomerSplitResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class VideoCustomerSplitResponseBodyResultCreateServiceRecordResult extends TeaModel {
        @NameInMap("recordIds")
        public java.util.List<String> recordIds;

        @NameInMap("segmentId")
        public String segmentId;

        public static VideoCustomerSplitResponseBodyResultCreateServiceRecordResult build(java.util.Map<String, ?> map) throws Exception {
            VideoCustomerSplitResponseBodyResultCreateServiceRecordResult self = new VideoCustomerSplitResponseBodyResultCreateServiceRecordResult();
            return TeaModel.build(map, self);
        }

        public VideoCustomerSplitResponseBodyResultCreateServiceRecordResult setRecordIds(java.util.List<String> recordIds) {
            this.recordIds = recordIds;
            return this;
        }
        public java.util.List<String> getRecordIds() {
            return this.recordIds;
        }

        public VideoCustomerSplitResponseBodyResultCreateServiceRecordResult setSegmentId(String segmentId) {
            this.segmentId = segmentId;
            return this;
        }
        public String getSegmentId() {
            return this.segmentId;
        }

    }

    public static class VideoCustomerSplitResponseBodyResult extends TeaModel {
        @NameInMap("createServiceRecordResult")
        public java.util.List<VideoCustomerSplitResponseBodyResultCreateServiceRecordResult> createServiceRecordResult;

        public static VideoCustomerSplitResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            VideoCustomerSplitResponseBodyResult self = new VideoCustomerSplitResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public VideoCustomerSplitResponseBodyResult setCreateServiceRecordResult(java.util.List<VideoCustomerSplitResponseBodyResultCreateServiceRecordResult> createServiceRecordResult) {
            this.createServiceRecordResult = createServiceRecordResult;
            return this;
        }
        public java.util.List<VideoCustomerSplitResponseBodyResultCreateServiceRecordResult> getCreateServiceRecordResult() {
            return this.createServiceRecordResult;
        }

    }

}
