// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetUserSignedRecordsByOuterIdResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetUserSignedRecordsByOuterIdResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetUserSignedRecordsByOuterIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserSignedRecordsByOuterIdResponseBody self = new GetUserSignedRecordsByOuterIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserSignedRecordsByOuterIdResponseBody setResult(java.util.List<GetUserSignedRecordsByOuterIdResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetUserSignedRecordsByOuterIdResponseBodyResult> getResult() {
        return this.result;
    }

    public GetUserSignedRecordsByOuterIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetUserSignedRecordsByOuterIdResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding33a9d1a6e9647854a39a90f97fcb1e09</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>CONTRACT_123456</p>
         */
        @NameInMap("outerId")
        public String outerId;

        /**
         * <strong>example:</strong>
         * <p>测试</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>1720775436000</p>
         */
        @NameInMap("signExpireTime")
        public String signExpireTime;

        /**
         * <strong>example:</strong>
         * <p>小明-劳动合同-20240808.pdf</p>
         */
        @NameInMap("signFileName")
        public String signFileName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://n.dingtalk.com/xxx">https://n.dingtalk.com/xxx</a></p>
         */
        @NameInMap("signFileUrl")
        public String signFileUrl;

        /**
         * <strong>example:</strong>
         * <p>1720775436000</p>
         */
        @NameInMap("signFinishTime")
        public String signFinishTime;

        /**
         * <strong>example:</strong>
         * <p>xx公司</p>
         */
        @NameInMap("signLegalEntityName")
        public String signLegalEntityName;

        /**
         * <strong>example:</strong>
         * <p>fb1a9c4adaba4f52b7cab7941008b9dd</p>
         */
        @NameInMap("signRecordId")
        public String signRecordId;

        /**
         * <strong>example:</strong>
         * <p>1720775436000</p>
         */
        @NameInMap("signStartTime")
        public String signStartTime;

        /**
         * <strong>example:</strong>
         * <p>FINISHED</p>
         */
        @NameInMap("signStatus")
        public String signStatus;

        /**
         * <strong>example:</strong>
         * <p>法人公司未开通</p>
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
         * <p>userId123</p>
         */
        @NameInMap("signUserId")
        public String signUserId;

        /**
         * <strong>example:</strong>
         * <p>userName</p>
         */
        @NameInMap("signUserName")
        public String signUserName;

        /**
         * <strong>example:</strong>
         * <p>ON_LINE</p>
         */
        @NameInMap("signWay")
        public String signWay;

        public static GetUserSignedRecordsByOuterIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserSignedRecordsByOuterIdResponseBodyResult self = new GetUserSignedRecordsByOuterIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setOuterId(String outerId) {
            this.outerId = outerId;
            return this;
        }
        public String getOuterId() {
            return this.outerId;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignExpireTime(String signExpireTime) {
            this.signExpireTime = signExpireTime;
            return this;
        }
        public String getSignExpireTime() {
            return this.signExpireTime;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignFileName(String signFileName) {
            this.signFileName = signFileName;
            return this;
        }
        public String getSignFileName() {
            return this.signFileName;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignFileUrl(String signFileUrl) {
            this.signFileUrl = signFileUrl;
            return this;
        }
        public String getSignFileUrl() {
            return this.signFileUrl;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignFinishTime(String signFinishTime) {
            this.signFinishTime = signFinishTime;
            return this;
        }
        public String getSignFinishTime() {
            return this.signFinishTime;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignLegalEntityName(String signLegalEntityName) {
            this.signLegalEntityName = signLegalEntityName;
            return this;
        }
        public String getSignLegalEntityName() {
            return this.signLegalEntityName;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignRecordId(String signRecordId) {
            this.signRecordId = signRecordId;
            return this;
        }
        public String getSignRecordId() {
            return this.signRecordId;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignStartTime(String signStartTime) {
            this.signStartTime = signStartTime;
            return this;
        }
        public String getSignStartTime() {
            return this.signStartTime;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignStatus(String signStatus) {
            this.signStatus = signStatus;
            return this;
        }
        public String getSignStatus() {
            return this.signStatus;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignStatusRemarks(String signStatusRemarks) {
            this.signStatusRemarks = signStatusRemarks;
            return this;
        }
        public String getSignStatusRemarks() {
            return this.signStatusRemarks;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignTemplateType(String signTemplateType) {
            this.signTemplateType = signTemplateType;
            return this;
        }
        public String getSignTemplateType() {
            return this.signTemplateType;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignUserId(String signUserId) {
            this.signUserId = signUserId;
            return this;
        }
        public String getSignUserId() {
            return this.signUserId;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignUserName(String signUserName) {
            this.signUserName = signUserName;
            return this;
        }
        public String getSignUserName() {
            return this.signUserName;
        }

        public GetUserSignedRecordsByOuterIdResponseBodyResult setSignWay(String signWay) {
            this.signWay = signWay;
            return this;
        }
        public String getSignWay() {
            return this.signWay;
        }

    }

}
