// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteTransferEvalRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteTransferEvalRequestParams> params;

    public static HrbrainDeleteTransferEvalRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteTransferEvalRequest self = new HrbrainDeleteTransferEvalRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteTransferEvalRequest setParams(java.util.List<HrbrainDeleteTransferEvalRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteTransferEvalRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteTransferEvalRequestParams extends TeaModel {
        @NameInMap("transferDate")
        public String transferDate;

        @NameInMap("transferType")
        public String transferType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteTransferEvalRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteTransferEvalRequestParams self = new HrbrainDeleteTransferEvalRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteTransferEvalRequestParams setTransferDate(String transferDate) {
            this.transferDate = transferDate;
            return this;
        }
        public String getTransferDate() {
            return this.transferDate;
        }

        public HrbrainDeleteTransferEvalRequestParams setTransferType(String transferType) {
            this.transferType = transferType;
            return this;
        }
        public String getTransferType() {
            return this.transferType;
        }

        public HrbrainDeleteTransferEvalRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
