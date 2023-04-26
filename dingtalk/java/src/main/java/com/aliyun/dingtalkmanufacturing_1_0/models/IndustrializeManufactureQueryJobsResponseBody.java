// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsResponseBody extends TeaModel {
    @NameInMap("content")
    public IndustrializeManufactureQueryJobsResponseBodyContent content;

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
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("id")
        public Long id;

        @NameInMap("instNo")
        public String instNo;

        @NameInMap("isBatchJob")
        public String isBatchJob;

        @NameInMap("manufactureDate")
        public String manufactureDate;

        @NameInMap("manufactureDay")
        public String manufactureDay;

        @NameInMap("mesAppKey")
        public String mesAppKey;

        @NameInMap("processName")
        public String processName;

        @NameInMap("qualifiedQuantity")
        public String qualifiedQuantity;

        @NameInMap("scrappedQuantity")
        public String scrappedQuantity;

        @NameInMap("unitPrice")
        public String unitPrice;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userIdList")
        public String userIdList;

        @NameInMap("userNameList")
        public String userNameList;

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
