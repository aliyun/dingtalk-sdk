// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsResponseBody extends TeaModel {
    // 查询的数据结果
    @NameInMap("content")
    public IndustrializeManufactureQueryJobsResponseBodyContent content;

    // httpCode
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
        // 组织id
        @NameInMap("corpId")
        public String corpId;

        // 创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        // 数据库id
        @NameInMap("id")
        public Long id;

        // 工单id
        @NameInMap("instNo")
        public String instNo;

        // 是否是批量报工，即一次报工由多个工人一起分担，取值[n,y],y表示是批量，批量时多个人名以英文逗号分隔
        @NameInMap("isBatchJob")
        public String isBatchJob;

        // 生产日期时间(到时分秒),格式:2021-07-05 08:00:21
        @NameInMap("manufactureDate")
        public String manufactureDate;

        // 生产日期(到天)
        @NameInMap("manufactureDay")
        public String manufactureDay;

        // 分配给mes系统的appkey
        @NameInMap("mesAppKey")
        public String mesAppKey;

        // 工序名称
        @NameInMap("processName")
        public String processName;

        // 合格数
        @NameInMap("qualifiedQuantity")
        public String qualifiedQuantity;

        // 不合格数
        @NameInMap("scrappedQuantity")
        public String scrappedQuantity;

        // 计件单价，单位：分
        @NameInMap("unitPrice")
        public String unitPrice;

        // 工人工号(isBatchJob=='n'时)
        @NameInMap("userId")
        public String userId;

        // 批量报工时多个人钉钉工号以英文逗号分隔
        @NameInMap("userIdList")
        public String userIdList;

        // 批量报工时多个人名以英文逗号分隔
        @NameInMap("userNameList")
        public String userNameList;

        // 报工记录的唯一标识
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
