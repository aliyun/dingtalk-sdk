// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsResponseBody extends TeaModel {
    @NameInMap("content")
    public IndustrializeManufactureQueryJobsResponseBodyContent content;

    /**
     * <strong>example:</strong>
     * <p>200</p>
     */
    @NameInMap("httpCode")
    public String httpCode;

    public static IndustrializeManufactureQueryJobsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureQueryJobsResponseBody self = new IndustrializeManufactureQueryJobsResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureQueryJobsResponseBody setContent(IndustrializeManufactureQueryJobsResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public IndustrializeManufactureQueryJobsResponseBodyContent getContent() {
        return this.content;
    }

    public IndustrializeManufactureQueryJobsResponseBody setHttpCode(String httpCode) {
        this.httpCode = httpCode;
        return this;
    }
    public String getHttpCode() {
        return this.httpCode;
    }

    public static class IndustrializeManufactureQueryJobsResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dingdb6elngd253073ad370d8dc3ec89bb366ab</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("instNo")
        public String instNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("isBatchJob")
        public String isBatchJob;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("manufactureDate")
        public String manufactureDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("manufactureDay")
        public String manufactureDay;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mesAppKey")
        public String mesAppKey;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("processName")
        public String processName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("qualifiedQuantity")
        public String qualifiedQuantity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("scrappedQuantity")
        public String scrappedQuantity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unitPrice")
        public String unitPrice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userIdList")
        public String userIdList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userNameList")
        public String userNameList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uuid")
        public String uuid;

        public static IndustrializeManufactureQueryJobsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            IndustrializeManufactureQueryJobsResponseBodyContent self = new IndustrializeManufactureQueryJobsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setInstNo(String instNo) {
            this.instNo = instNo;
            return this;
        }
        public String getInstNo() {
            return this.instNo;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setIsBatchJob(String isBatchJob) {
            this.isBatchJob = isBatchJob;
            return this;
        }
        public String getIsBatchJob() {
            return this.isBatchJob;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setManufactureDate(String manufactureDate) {
            this.manufactureDate = manufactureDate;
            return this;
        }
        public String getManufactureDate() {
            return this.manufactureDate;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setManufactureDay(String manufactureDay) {
            this.manufactureDay = manufactureDay;
            return this;
        }
        public String getManufactureDay() {
            return this.manufactureDay;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setMesAppKey(String mesAppKey) {
            this.mesAppKey = mesAppKey;
            return this;
        }
        public String getMesAppKey() {
            return this.mesAppKey;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setProcessName(String processName) {
            this.processName = processName;
            return this;
        }
        public String getProcessName() {
            return this.processName;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setQualifiedQuantity(String qualifiedQuantity) {
            this.qualifiedQuantity = qualifiedQuantity;
            return this;
        }
        public String getQualifiedQuantity() {
            return this.qualifiedQuantity;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setScrappedQuantity(String scrappedQuantity) {
            this.scrappedQuantity = scrappedQuantity;
            return this;
        }
        public String getScrappedQuantity() {
            return this.scrappedQuantity;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setUserIdList(String userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public String getUserIdList() {
            return this.userIdList;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setUserNameList(String userNameList) {
            this.userNameList = userNameList;
            return this;
        }
        public String getUserNameList() {
            return this.userNameList;
        }

        public IndustrializeManufactureQueryJobsResponseBodyContent setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
