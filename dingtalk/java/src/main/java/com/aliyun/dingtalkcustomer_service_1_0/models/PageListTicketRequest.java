// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListTicketRequest extends TeaModel {
    // 实例id
    @NameInMap("openInstanceId")
    public String openInstanceId;

    // 产品类型
    @NameInMap("productionType")
    public Integer productionType;

    // 工单模板
    @NameInMap("templateId")
    public String templateId;

    // 工单ID
    @NameInMap("ticketId")
    public String ticketId;

    // 来源
    @NameInMap("sourceId")
    public String sourceId;

    // 第三方用户id
    @NameInMap("foreignId")
    public String foreignId;

    // 工单状态
    @NameInMap("ticketStatus")
    public String ticketStatus;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 用来标记当前开始读取的位置，置空表示从头开始
    @NameInMap("nextToken")
    public String nextToken;

    // 本次读取的最大数据记录数量
    @NameInMap("maxResults")
    public Integer maxResults;

    public static PageListTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListTicketRequest self = new PageListTicketRequest();
        return TeaModel.build(map, self);
    }

    public PageListTicketRequest setOpenInstanceId(String openInstanceId) {
        this.openInstanceId = openInstanceId;
        return this;
    }
    public String getOpenInstanceId() {
        return this.openInstanceId;
    }

    public PageListTicketRequest setProductionType(Integer productionType) {
        this.productionType = productionType;
        return this;
    }
    public Integer getProductionType() {
        return this.productionType;
    }

    public PageListTicketRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public PageListTicketRequest setTicketId(String ticketId) {
        this.ticketId = ticketId;
        return this;
    }
    public String getTicketId() {
        return this.ticketId;
    }

    public PageListTicketRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public PageListTicketRequest setForeignId(String foreignId) {
        this.foreignId = foreignId;
        return this;
    }
    public String getForeignId() {
        return this.foreignId;
    }

    public PageListTicketRequest setTicketStatus(String ticketStatus) {
        this.ticketStatus = ticketStatus;
        return this;
    }
    public String getTicketStatus() {
        return this.ticketStatus;
    }

    public PageListTicketRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public PageListTicketRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public PageListTicketRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PageListTicketRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
