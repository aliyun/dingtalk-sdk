// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CheckControlHitStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public CheckControlHitStatusResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CheckControlHitStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckControlHitStatusResponseBody self = new CheckControlHitStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckControlHitStatusResponseBody setResult(CheckControlHitStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CheckControlHitStatusResponseBodyResult getResult() {
        return this.result;
    }

    public CheckControlHitStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CheckControlHitStatusResponseBodyResult extends TeaModel {
        @NameInMap("controlList")
        public java.util.List<String> controlList;

        @NameInMap("controlStatus")
        public Integer controlStatus;

        @NameInMap("reason")
        public String reason;

        public static CheckControlHitStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CheckControlHitStatusResponseBodyResult self = new CheckControlHitStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CheckControlHitStatusResponseBodyResult setControlList(java.util.List<String> controlList) {
            this.controlList = controlList;
            return this;
        }
        public java.util.List<String> getControlList() {
            return this.controlList;
        }

        public CheckControlHitStatusResponseBodyResult setControlStatus(Integer controlStatus) {
            this.controlStatus = controlStatus;
            return this;
        }
        public Integer getControlStatus() {
            return this.controlStatus;
        }

        public CheckControlHitStatusResponseBodyResult setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

    }

}
