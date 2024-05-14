// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportTransferEvalRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportTransferEvalRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportTransferEvalRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportTransferEvalRequest self = new HrbrainImportTransferEvalRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportTransferEvalRequest setBody(java.util.List<HrbrainImportTransferEvalRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportTransferEvalRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportTransferEvalRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportTransferEvalRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("currInfo")
        public java.util.Map<String, ?> currInfo;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("preInfo")
        public java.util.Map<String, ?> preInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("transferDate")
        public String transferDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("transferReason")
        public String transferReason;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("transferType")
        public String transferType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportTransferEvalRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportTransferEvalRequestBody self = new HrbrainImportTransferEvalRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportTransferEvalRequestBody setCurrInfo(java.util.Map<String, ?> currInfo) {
            this.currInfo = currInfo;
            return this;
        }
        public java.util.Map<String, ?> getCurrInfo() {
            return this.currInfo;
        }

        public HrbrainImportTransferEvalRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportTransferEvalRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportTransferEvalRequestBody setPreInfo(java.util.Map<String, ?> preInfo) {
            this.preInfo = preInfo;
            return this;
        }
        public java.util.Map<String, ?> getPreInfo() {
            return this.preInfo;
        }

        public HrbrainImportTransferEvalRequestBody setTransferDate(String transferDate) {
            this.transferDate = transferDate;
            return this;
        }
        public String getTransferDate() {
            return this.transferDate;
        }

        public HrbrainImportTransferEvalRequestBody setTransferReason(String transferReason) {
            this.transferReason = transferReason;
            return this;
        }
        public String getTransferReason() {
            return this.transferReason;
        }

        public HrbrainImportTransferEvalRequestBody setTransferType(String transferType) {
            this.transferType = transferType;
            return this;
        }
        public String getTransferType() {
            return this.transferType;
        }

        public HrbrainImportTransferEvalRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
