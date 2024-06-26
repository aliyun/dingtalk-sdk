// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class AssignOrgHoldingToEmpHoldingBatchResponseBody extends TeaModel {
    @NameInMap("result")
    public AssignOrgHoldingToEmpHoldingBatchResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AssignOrgHoldingToEmpHoldingBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AssignOrgHoldingToEmpHoldingBatchResponseBody self = new AssignOrgHoldingToEmpHoldingBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public AssignOrgHoldingToEmpHoldingBatchResponseBody setResult(AssignOrgHoldingToEmpHoldingBatchResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AssignOrgHoldingToEmpHoldingBatchResponseBodyResult getResult() {
        return this.result;
    }

    public AssignOrgHoldingToEmpHoldingBatchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>SUCCESS</p>
         */
        @NameInMap("invokeStatus")
        public String invokeStatus;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("msg")
        public String msg;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>23423568784</p>
         */
        @NameInMap("outId")
        public String outId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>01274411491620908910</p>
         */
        @NameInMap("userId")
        public String userId;

        public static AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS build(java.util.Map<String, ?> map) throws Exception {
            AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS self = new AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS();
            return TeaModel.build(map, self);
        }

        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS setInvokeStatus(String invokeStatus) {
            this.invokeStatus = invokeStatus;
            return this;
        }
        public String getInvokeStatus() {
            return this.invokeStatus;
        }

        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS setMsg(String msg) {
            this.msg = msg;
            return this;
        }
        public String getMsg() {
            return this.msg;
        }

        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class AssignOrgHoldingToEmpHoldingBatchResponseBodyResult extends TeaModel {
        @NameInMap("openPointInvokeResultDTOS")
        public java.util.List<AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS> openPointInvokeResultDTOS;

        public static AssignOrgHoldingToEmpHoldingBatchResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AssignOrgHoldingToEmpHoldingBatchResponseBodyResult self = new AssignOrgHoldingToEmpHoldingBatchResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResult setOpenPointInvokeResultDTOS(java.util.List<AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS> openPointInvokeResultDTOS) {
            this.openPointInvokeResultDTOS = openPointInvokeResultDTOS;
            return this;
        }
        public java.util.List<AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS> getOpenPointInvokeResultDTOS() {
            return this.openPointInvokeResultDTOS;
        }

    }

}
