// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListTicketResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<PageListTicketResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("total")
    public Long total;

    public static PageListTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListTicketResponseBody self = new PageListTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListTicketResponseBody setList(java.util.List<PageListTicketResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PageListTicketResponseBodyList> getList() {
        return this.list;
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

    public static class PageListTicketResponseBodyList extends TeaModel {
        @NameInMap("bizDataMap")
        public java.util.Map<String, ?> bizDataMap;

        @NameInMap("foreignId")
        public String foreignId;

        @NameInMap("foreignName")
        public String foreignName;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("openInstanceId")
        public String openInstanceId;

        @NameInMap("productionType")
        public Integer productionType;

        @NameInMap("sourceId")
        public String sourceId;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("ticketId")
        public String ticketId;

        @NameInMap("ticketStatus")
        public String ticketStatus;

        @NameInMap("title")
        public String title;

        public static PageListTicketResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            PageListTicketResponseBodyList self = new PageListTicketResponseBodyList();
            return TeaModel.build(map, self);
        }

        public PageListTicketResponseBodyList setBizDataMap(java.util.Map<String, ?> bizDataMap) {
            this.bizDataMap = bizDataMap;
            return this;
        }
        public java.util.Map<String, ?> getBizDataMap() {
            return this.bizDataMap;
        }

        public PageListTicketResponseBodyList setForeignId(String foreignId) {
            this.foreignId = foreignId;
            return this;
        }
        public String getForeignId() {
            return this.foreignId;
        }

        public PageListTicketResponseBodyList setForeignName(String foreignName) {
            this.foreignName = foreignName;
            return this;
        }
        public String getForeignName() {
            return this.foreignName;
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

        public PageListTicketResponseBodyList setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public PageListTicketResponseBodyList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
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

        public PageListTicketResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
