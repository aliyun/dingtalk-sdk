// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSendAndReceiveReportListResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<GetSendAndReceiveReportListResponseBodyDataList> dataList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    public static GetSendAndReceiveReportListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSendAndReceiveReportListResponseBody self = new GetSendAndReceiveReportListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSendAndReceiveReportListResponseBody setDataList(java.util.List<GetSendAndReceiveReportListResponseBodyDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<GetSendAndReceiveReportListResponseBodyDataList> getDataList() {
        return this.dataList;
    }

    public GetSendAndReceiveReportListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetSendAndReceiveReportListResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSendAndReceiveReportListResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class GetSendAndReceiveReportListResponseBodyDataList extends TeaModel {
        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("creatorName")
        public String creatorName;

        @NameInMap("modifiedTime")
        public Long modifiedTime;

        @NameInMap("reportId")
        public String reportId;

        @NameInMap("templateName")
        public String templateName;

        public static GetSendAndReceiveReportListResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            GetSendAndReceiveReportListResponseBodyDataList self = new GetSendAndReceiveReportListResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public GetSendAndReceiveReportListResponseBodyDataList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetSendAndReceiveReportListResponseBodyDataList setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetSendAndReceiveReportListResponseBodyDataList setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public GetSendAndReceiveReportListResponseBodyDataList setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public GetSendAndReceiveReportListResponseBodyDataList setReportId(String reportId) {
            this.reportId = reportId;
            return this;
        }
        public String getReportId() {
            return this.reportId;
        }

        public GetSendAndReceiveReportListResponseBodyDataList setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

    }

}
