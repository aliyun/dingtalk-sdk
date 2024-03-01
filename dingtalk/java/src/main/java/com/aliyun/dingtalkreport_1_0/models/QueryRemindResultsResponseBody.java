// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class QueryRemindResultsResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<QueryRemindResultsResponseBodyDataList> dataList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryRemindResultsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRemindResultsResponseBody self = new QueryRemindResultsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRemindResultsResponseBody setDataList(java.util.List<QueryRemindResultsResponseBodyDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<QueryRemindResultsResponseBodyDataList> getDataList() {
        return this.dataList;
    }

    public QueryRemindResultsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryRemindResultsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryRemindResultsResponseBodyDataListToGroups extends TeaModel {
        @NameInMap("title")
        public String title;

        public static QueryRemindResultsResponseBodyDataListToGroups build(java.util.Map<String, ?> map) throws Exception {
            QueryRemindResultsResponseBodyDataListToGroups self = new QueryRemindResultsResponseBodyDataListToGroups();
            return TeaModel.build(map, self);
        }

        public QueryRemindResultsResponseBodyDataListToGroups setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryRemindResultsResponseBodyDataList extends TeaModel {
        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("endDateTime")
        public java.util.List<String> endDateTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("periodType")
        public Integer periodType;

        @NameInMap("remindId")
        public Long remindId;

        @NameInMap("startDateTime")
        public java.util.List<String> startDateTime;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("toGroups")
        public java.util.List<QueryRemindResultsResponseBodyDataListToGroups> toGroups;

        public static QueryRemindResultsResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            QueryRemindResultsResponseBodyDataList self = new QueryRemindResultsResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public QueryRemindResultsResponseBodyDataList setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryRemindResultsResponseBodyDataList setEndDateTime(java.util.List<String> endDateTime) {
            this.endDateTime = endDateTime;
            return this;
        }
        public java.util.List<String> getEndDateTime() {
            return this.endDateTime;
        }

        public QueryRemindResultsResponseBodyDataList setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public QueryRemindResultsResponseBodyDataList setPeriodType(Integer periodType) {
            this.periodType = periodType;
            return this;
        }
        public Integer getPeriodType() {
            return this.periodType;
        }

        public QueryRemindResultsResponseBodyDataList setRemindId(Long remindId) {
            this.remindId = remindId;
            return this;
        }
        public Long getRemindId() {
            return this.remindId;
        }

        public QueryRemindResultsResponseBodyDataList setStartDateTime(java.util.List<String> startDateTime) {
            this.startDateTime = startDateTime;
            return this;
        }
        public java.util.List<String> getStartDateTime() {
            return this.startDateTime;
        }

        public QueryRemindResultsResponseBodyDataList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public QueryRemindResultsResponseBodyDataList setToGroups(java.util.List<QueryRemindResultsResponseBodyDataListToGroups> toGroups) {
            this.toGroups = toGroups;
            return this;
        }
        public java.util.List<QueryRemindResultsResponseBodyDataListToGroups> getToGroups() {
            return this.toGroups;
        }

    }

}
