// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetSignRecordByUserIdResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSignRecordByUserIdResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetSignRecordByUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignRecordByUserIdResponseBody self = new GetSignRecordByUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignRecordByUserIdResponseBody setResult(GetSignRecordByUserIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSignRecordByUserIdResponseBodyResult getResult() {
        return this.result;
    }

    public GetSignRecordByUserIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetSignRecordByUserIdResponseBodyResultData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding57935b18bfd13e9735c2f4657eb6378f</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>劳动合同电子签签署备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>1720775436000</p>
         */
        @NameInMap("signExpireTime")
        public Long signExpireTime;

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
        public Long signFinishTime;

        /**
         * <strong>example:</strong>
         * <p>xxx有限公司</p>
         */
        @NameInMap("signLegalEntityName")
        public String signLegalEntityName;

        /**
         * <strong>example:</strong>
         * <p>38bc7b69bb6a46b8a69b9001d5c0bdf3</p>
         */
        @NameInMap("signRecordId")
        public String signRecordId;

        /**
         * <strong>example:</strong>
         * <p>1720775436000</p>
         */
        @NameInMap("signStartTime")
        public Long signStartTime;

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
         * <p>660658</p>
         */
        @NameInMap("signUserId")
        public String signUserId;

        /**
         * <strong>example:</strong>
         * <p>小明</p>
         */
        @NameInMap("signUserName")
        public String signUserName;

        /**
         * <strong>example:</strong>
         * <p>ON_LINE</p>
         */
        @NameInMap("signWay")
        public String signWay;

        public static GetSignRecordByUserIdResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            GetSignRecordByUserIdResponseBodyResultData self = new GetSignRecordByUserIdResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public GetSignRecordByUserIdResponseBodyResultData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetSignRecordByUserIdResponseBodyResultData setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignExpireTime(Long signExpireTime) {
            this.signExpireTime = signExpireTime;
            return this;
        }
        public Long getSignExpireTime() {
            return this.signExpireTime;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignFileName(String signFileName) {
            this.signFileName = signFileName;
            return this;
        }
        public String getSignFileName() {
            return this.signFileName;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignFileUrl(String signFileUrl) {
            this.signFileUrl = signFileUrl;
            return this;
        }
        public String getSignFileUrl() {
            return this.signFileUrl;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignFinishTime(Long signFinishTime) {
            this.signFinishTime = signFinishTime;
            return this;
        }
        public Long getSignFinishTime() {
            return this.signFinishTime;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignLegalEntityName(String signLegalEntityName) {
            this.signLegalEntityName = signLegalEntityName;
            return this;
        }
        public String getSignLegalEntityName() {
            return this.signLegalEntityName;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignRecordId(String signRecordId) {
            this.signRecordId = signRecordId;
            return this;
        }
        public String getSignRecordId() {
            return this.signRecordId;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignStartTime(Long signStartTime) {
            this.signStartTime = signStartTime;
            return this;
        }
        public Long getSignStartTime() {
            return this.signStartTime;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignStatus(String signStatus) {
            this.signStatus = signStatus;
            return this;
        }
        public String getSignStatus() {
            return this.signStatus;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignStatusRemarks(String signStatusRemarks) {
            this.signStatusRemarks = signStatusRemarks;
            return this;
        }
        public String getSignStatusRemarks() {
            return this.signStatusRemarks;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignTemplateType(String signTemplateType) {
            this.signTemplateType = signTemplateType;
            return this;
        }
        public String getSignTemplateType() {
            return this.signTemplateType;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignUserId(String signUserId) {
            this.signUserId = signUserId;
            return this;
        }
        public String getSignUserId() {
            return this.signUserId;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignUserName(String signUserName) {
            this.signUserName = signUserName;
            return this;
        }
        public String getSignUserName() {
            return this.signUserName;
        }

        public GetSignRecordByUserIdResponseBodyResultData setSignWay(String signWay) {
            this.signWay = signWay;
            return this;
        }
        public String getSignWay() {
            return this.signWay;
        }

    }

    public static class GetSignRecordByUserIdResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<GetSignRecordByUserIdResponseBodyResultData> data;

        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("nextToken")
        public Long nextToken;

        public static GetSignRecordByUserIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSignRecordByUserIdResponseBodyResult self = new GetSignRecordByUserIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSignRecordByUserIdResponseBodyResult setData(java.util.List<GetSignRecordByUserIdResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<GetSignRecordByUserIdResponseBodyResultData> getData() {
            return this.data;
        }

        public GetSignRecordByUserIdResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetSignRecordByUserIdResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

    }

}
