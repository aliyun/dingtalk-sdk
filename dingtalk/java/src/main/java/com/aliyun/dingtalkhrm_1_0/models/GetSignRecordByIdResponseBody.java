// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetSignRecordByIdResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetSignRecordByIdResponseBodyResult> result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetSignRecordByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignRecordByIdResponseBody self = new GetSignRecordByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignRecordByIdResponseBody setResult(java.util.List<GetSignRecordByIdResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetSignRecordByIdResponseBodyResult> getResult() {
        return this.result;
    }

    public GetSignRecordByIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetSignRecordByIdResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding12345678</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>员工签署中</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>1723534265000</p>
         */
        @NameInMap("signExpireTime")
        public Long signExpireTime;

        /**
         * <strong>example:</strong>
         * <p>xxxx-合同文件.pdf</p>
         */
        @NameInMap("signFileName")
        public String signFileName;

        /**
         * <strong>example:</strong>
         * <p>1723534265000</p>
         */
        @NameInMap("signFinishTime")
        public Long signFinishTime;

        /**
         * <strong>example:</strong>
         * <p>xxxx有限公司</p>
         */
        @NameInMap("signLegalEntityName")
        public String signLegalEntityName;

        /**
         * <strong>example:</strong>
         * <p>6fe06f57ab5a45078f3219be8fd829c6</p>
         */
        @NameInMap("signRecordId")
        public String signRecordId;

        /**
         * <strong>example:</strong>
         * <p>1723534265000</p>
         */
        @NameInMap("signStartTime")
        public Long signStartTime;

        /**
         * <strong>example:</strong>
         * <p>SIGNING</p>
         */
        @NameInMap("signStatus")
        public String signStatus;

        /**
         * <strong>example:</strong>
         * <p>签署中</p>
         */
        @NameInMap("signStatusRemarks")
        public String signStatusRemarks;

        /**
         * <strong>example:</strong>
         * <p>CONTRACT</p>
         */
        @NameInMap("signTemplateType")
        public String signTemplateType;

        /**
         * <strong>example:</strong>
         * <p>400873120394</p>
         */
        @NameInMap("signUserId")
        public String signUserId;

        /**
         * <strong>example:</strong>
         * <p>xiaoming</p>
         */
        @NameInMap("signUserName")
        public String signUserName;

        /**
         * <strong>example:</strong>
         * <p>ON_LINE</p>
         */
        @NameInMap("signWay")
        public String signWay;

        public static GetSignRecordByIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSignRecordByIdResponseBodyResult self = new GetSignRecordByIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSignRecordByIdResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetSignRecordByIdResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetSignRecordByIdResponseBodyResult setSignExpireTime(Long signExpireTime) {
            this.signExpireTime = signExpireTime;
            return this;
        }
        public Long getSignExpireTime() {
            return this.signExpireTime;
        }

        public GetSignRecordByIdResponseBodyResult setSignFileName(String signFileName) {
            this.signFileName = signFileName;
            return this;
        }
        public String getSignFileName() {
            return this.signFileName;
        }

        public GetSignRecordByIdResponseBodyResult setSignFinishTime(Long signFinishTime) {
            this.signFinishTime = signFinishTime;
            return this;
        }
        public Long getSignFinishTime() {
            return this.signFinishTime;
        }

        public GetSignRecordByIdResponseBodyResult setSignLegalEntityName(String signLegalEntityName) {
            this.signLegalEntityName = signLegalEntityName;
            return this;
        }
        public String getSignLegalEntityName() {
            return this.signLegalEntityName;
        }

        public GetSignRecordByIdResponseBodyResult setSignRecordId(String signRecordId) {
            this.signRecordId = signRecordId;
            return this;
        }
        public String getSignRecordId() {
            return this.signRecordId;
        }

        public GetSignRecordByIdResponseBodyResult setSignStartTime(Long signStartTime) {
            this.signStartTime = signStartTime;
            return this;
        }
        public Long getSignStartTime() {
            return this.signStartTime;
        }

        public GetSignRecordByIdResponseBodyResult setSignStatus(String signStatus) {
            this.signStatus = signStatus;
            return this;
        }
        public String getSignStatus() {
            return this.signStatus;
        }

        public GetSignRecordByIdResponseBodyResult setSignStatusRemarks(String signStatusRemarks) {
            this.signStatusRemarks = signStatusRemarks;
            return this;
        }
        public String getSignStatusRemarks() {
            return this.signStatusRemarks;
        }

        public GetSignRecordByIdResponseBodyResult setSignTemplateType(String signTemplateType) {
            this.signTemplateType = signTemplateType;
            return this;
        }
        public String getSignTemplateType() {
            return this.signTemplateType;
        }

        public GetSignRecordByIdResponseBodyResult setSignUserId(String signUserId) {
            this.signUserId = signUserId;
            return this;
        }
        public String getSignUserId() {
            return this.signUserId;
        }

        public GetSignRecordByIdResponseBodyResult setSignUserName(String signUserName) {
            this.signUserName = signUserName;
            return this;
        }
        public String getSignUserName() {
            return this.signUserName;
        }

        public GetSignRecordByIdResponseBodyResult setSignWay(String signWay) {
            this.signWay = signWay;
            return this;
        }
        public String getSignWay() {
            return this.signWay;
        }

    }

}
