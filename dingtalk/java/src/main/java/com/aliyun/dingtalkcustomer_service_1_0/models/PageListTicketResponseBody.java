// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListTicketResponseBody extends TeaModel {
    // nextCursor
    @NameInMap("nextCursor")
    public Long nextCursor;

    // total
    @NameInMap("total")
    public Long total;

    // list
    @NameInMap("list")
    public java.util.List<PageListTicketResponseBodyList> list;

    public static PageListTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListTicketResponseBody self = new PageListTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListTicketResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public PageListTicketResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public PageListTicketResponseBody setList(java.util.List<PageListTicketResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PageListTicketResponseBodyList> getList() {
        return this.list;
    }

    public static class PageListTicketResponseBodyList extends TeaModel {
        // foreignId
        @NameInMap("foreignId")
        public String foreignId;

        // sourceId
        @NameInMap("sourceId")
        public String sourceId;

        // foreignName
        @NameInMap("foreignName")
        public String foreignName;

        // templateId
        @NameInMap("templateId")
        public String templateId;

        // title
        @NameInMap("title")
        public String title;

        // ticketId
        @NameInMap("ticketId")
        public String ticketId;

        // ticketStatus
        @NameInMap("ticketStatus")
        public String ticketStatus;

        // openInstanceId
        @NameInMap("openInstanceId")
        public String openInstanceId;

        // productionType
        @NameInMap("productionType")
        public Integer productionType;

        // gmtCreate
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // gmtModified
        @NameInMap("gmtModified")
        public String gmtModified;

        // bizDataMap
        @NameInMap("bizDataMap")
        public java.util.Map<String, ?> bizDataMap;

        public static PageListTicketResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            PageListTicketResponseBodyList self = new PageListTicketResponseBodyList();
            return TeaModel.build(map, self);
        }

        public PageListTicketResponseBodyList setForeignId(String foreignId) {
            this.foreignId = foreignId;
            return this;
        }
        public String getForeignId() {
            return this.foreignId;
        }

        public PageListTicketResponseBodyList setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public PageListTicketResponseBodyList setForeignName(String foreignName) {
            this.foreignName = foreignName;
            return this;
        }
        public String getForeignName() {
            return this.foreignName;
        }

        public PageListTicketResponseBodyList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public PageListTicketResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public PageListTicketResponseBodyList setTicketId(String ticketId) {
            this.ticketId = ticketId;
            return this;
        }
        public String getTicketId() {
            return this.ticketId;
        }

        public PageListTicketResponseBodyList setTicketStatus(String ticketStatus) {
            this.ticketStatus = ticketStatus;
            return this;
        }
        public String getTicketStatus() {
            return this.ticketStatus;
        }

        public PageListTicketResponseBodyList setOpenInstanceId(String openInstanceId) {
            this.openInstanceId = openInstanceId;
            return this;
        }
        public String getOpenInstanceId() {
            return this.openInstanceId;
        }

        public PageListTicketResponseBodyList setProductionType(Integer productionType) {
            this.productionType = productionType;
            return this;
        }
        public Integer getProductionType() {
            return this.productionType;
        }

        public PageListTicketResponseBodyList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public PageListTicketResponseBodyList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public PageListTicketResponseBodyList setBizDataMap(java.util.Map<String, ?> bizDataMap) {
            this.bizDataMap = bizDataMap;
            return this;
        }
        public java.util.Map<String, ?> getBizDataMap() {
            return this.bizDataMap;
        }

    }

}
