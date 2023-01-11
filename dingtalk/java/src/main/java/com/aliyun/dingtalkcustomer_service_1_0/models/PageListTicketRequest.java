// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListTicketRequest extends TeaModel {
    /**
     * <p>结束时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>第三方用户id</p>
     */
    @NameInMap("foreignId")
    public String foreignId;

    /**
     * <p>本次读取的最大数据记录数量</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>用来标记当前开始读取的位置，置空表示从头开始</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>实例id</p>
     */
    @NameInMap("openInstanceId")
    public String openInstanceId;

    /**
     * <p>产品类型</p>
     */
    @NameInMap("productionType")
    public Integer productionType;

    /**
     * <p>来源</p>
     */
    @NameInMap("sourceId")
    public String sourceId;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>工单模板</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>工单ID</p>
     */
    @NameInMap("ticketId")
    public String ticketId;

    /**
     * <p>工单状态</p>
     */
    @NameInMap("ticketStatus")
    public String ticketStatus;

    public static PageListTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListTicketRequest self = new PageListTicketRequest();
        return TeaModel.build(map, self);
    }

    public PageListTicketRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public PageListTicketRequest setForeignId(String foreignId) {
        this.foreignId = foreignId;
        return this;
    }
    public String getForeignId() {
        return this.foreignId;
    }

    public PageListTicketRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public PageListTicketRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
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

    public PageListTicketRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public PageListTicketRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
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

    public PageListTicketRequest setTicketStatus(String ticketStatus) {
        this.ticketStatus = ticketStatus;
        return this;
    }
    public String getTicketStatus() {
        return this.ticketStatus;
    }

}
