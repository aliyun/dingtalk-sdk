// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsResponseBody extends TeaModel {
    /**
     * <p>查询的数据结果</p>
     */
    @NameInMap("content")
    public IndustrializeManufactureQueryJobsResponseBodyContent content;

    /**
     * <p>httpCode</p>
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
         * <p>组织id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>数据库id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>工单id</p>
         */
        @NameInMap("instNo")
        public String instNo;

        /**
         * <p>是否是批量报工，即一次报工由多个工人一起分担，取值[n,y],y表示是批量，批量时多个人名以英文逗号分隔</p>
         */
        @NameInMap("isBatchJob")
        public String isBatchJob;

        /**
         * <p>生产日期时间(到时分秒),格式:2021-07-05 08:00:21</p>
         */
        @NameInMap("manufactureDate")
        public String manufactureDate;

        /**
         * <p>生产日期(到天)</p>
         */
        @NameInMap("manufactureDay")
        public String manufactureDay;

        /**
         * <p>分配给mes系统的appkey</p>
         */
        @NameInMap("mesAppKey")
        public String mesAppKey;

        /**
         * <p>工序名称</p>
         */
        @NameInMap("processName")
        public String processName;

        /**
         * <p>合格数</p>
         */
        @NameInMap("qualifiedQuantity")
        public String qualifiedQuantity;

        /**
         * <p>不合格数</p>
         */
        @NameInMap("scrappedQuantity")
        public String scrappedQuantity;

        /**
         * <p>计件单价，单位：分</p>
         */
        @NameInMap("unitPrice")
        public String unitPrice;

        /**
         * <p>工人工号(isBatchJob=='n'时)</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>批量报工时多个人钉钉工号以英文逗号分隔</p>
         */
        @NameInMap("userIdList")
        public String userIdList;

        /**
         * <p>批量报工时多个人名以英文逗号分隔</p>
         */
        @NameInMap("userNameList")
        public String userNameList;

        /**
         * <p>报工记录的唯一标识</p>
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
