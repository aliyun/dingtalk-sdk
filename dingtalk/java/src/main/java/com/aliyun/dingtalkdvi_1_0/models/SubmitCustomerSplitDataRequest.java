// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitCustomerSplitDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("splitParams")
    public java.util.List<SubmitCustomerSplitDataRequestSplitParams> splitParams;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SubmitCustomerSplitDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitCustomerSplitDataRequest self = new SubmitCustomerSplitDataRequest();
        return TeaModel.build(map, self);
    }

    public SubmitCustomerSplitDataRequest setSplitParams(java.util.List<SubmitCustomerSplitDataRequestSplitParams> splitParams) {
        this.splitParams = splitParams;
        return this;
    }
    public java.util.List<SubmitCustomerSplitDataRequestSplitParams> getSplitParams() {
        return this.splitParams;
    }

    public SubmitCustomerSplitDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SubmitCustomerSplitDataRequestSplitParams extends TeaModel {
        @NameInMap("outBizData")
        public String outBizData;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        public static SubmitCustomerSplitDataRequestSplitParams build(java.util.Map<String, ?> map) throws Exception {
            SubmitCustomerSplitDataRequestSplitParams self = new SubmitCustomerSplitDataRequestSplitParams();
            return TeaModel.build(map, self);
        }

        public SubmitCustomerSplitDataRequestSplitParams setOutBizData(String outBizData) {
            this.outBizData = outBizData;
            return this;
        }
        public String getOutBizData() {
            return this.outBizData;
        }

        public SubmitCustomerSplitDataRequestSplitParams setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

}
