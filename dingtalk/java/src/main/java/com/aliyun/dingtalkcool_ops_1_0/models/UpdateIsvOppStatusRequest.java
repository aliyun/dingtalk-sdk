// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class UpdateIsvOppStatusRequest extends TeaModel {
    @NameInMap("isvOpportunityStatusList")
    public java.util.List<UpdateIsvOppStatusRequestIsvOpportunityStatusList> isvOpportunityStatusList;

    public static UpdateIsvOppStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateIsvOppStatusRequest self = new UpdateIsvOppStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateIsvOppStatusRequest setIsvOpportunityStatusList(java.util.List<UpdateIsvOppStatusRequestIsvOpportunityStatusList> isvOpportunityStatusList) {
        this.isvOpportunityStatusList = isvOpportunityStatusList;
        return this;
    }
    public java.util.List<UpdateIsvOppStatusRequestIsvOpportunityStatusList> getIsvOpportunityStatusList() {
        return this.isvOpportunityStatusList;
    }

    public static class UpdateIsvOppStatusRequestIsvOpportunityStatusList extends TeaModel {
        @NameInMap("isvCorpId")
        public String isvCorpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("microAppId")
        public String microAppId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("note")
        public String note;

        @NameInMap("operCorpId")
        public String operCorpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("operName")
        public String operName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("operTime")
        public String operTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("operUserId")
        public String operUserId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("oppSourceCorpId")
        public String oppSourceCorpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("opportunityStatus")
        public String opportunityStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateIsvOppStatusRequestIsvOpportunityStatusList build(java.util.Map<String, ?> map) throws Exception {
            UpdateIsvOppStatusRequestIsvOpportunityStatusList self = new UpdateIsvOppStatusRequestIsvOpportunityStatusList();
            return TeaModel.build(map, self);
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setIsvCorpId(String isvCorpId) {
            this.isvCorpId = isvCorpId;
            return this;
        }
        public String getIsvCorpId() {
            return this.isvCorpId;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setMicroAppId(String microAppId) {
            this.microAppId = microAppId;
            return this;
        }
        public String getMicroAppId() {
            return this.microAppId;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setOperCorpId(String operCorpId) {
            this.operCorpId = operCorpId;
            return this;
        }
        public String getOperCorpId() {
            return this.operCorpId;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setOperName(String operName) {
            this.operName = operName;
            return this;
        }
        public String getOperName() {
            return this.operName;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setOperTime(String operTime) {
            this.operTime = operTime;
            return this;
        }
        public String getOperTime() {
            return this.operTime;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setOperUserId(String operUserId) {
            this.operUserId = operUserId;
            return this;
        }
        public String getOperUserId() {
            return this.operUserId;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setOppSourceCorpId(String oppSourceCorpId) {
            this.oppSourceCorpId = oppSourceCorpId;
            return this;
        }
        public String getOppSourceCorpId() {
            return this.oppSourceCorpId;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setOpportunityStatus(String opportunityStatus) {
            this.opportunityStatus = opportunityStatus;
            return this;
        }
        public String getOpportunityStatus() {
            return this.opportunityStatus;
        }

        public UpdateIsvOppStatusRequestIsvOpportunityStatusList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
