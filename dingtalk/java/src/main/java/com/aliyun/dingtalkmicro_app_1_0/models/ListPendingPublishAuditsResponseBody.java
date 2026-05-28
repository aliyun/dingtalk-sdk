// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListPendingPublishAuditsResponseBody extends TeaModel {
    @NameInMap("auditList")
    public java.util.List<ListPendingPublishAuditsResponseBodyAuditList> auditList;

    @NameInMap("hasMore")
    public String hasMore;

    @NameInMap("nextPageToken")
    public String nextPageToken;

    public static ListPendingPublishAuditsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPendingPublishAuditsResponseBody self = new ListPendingPublishAuditsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPendingPublishAuditsResponseBody setAuditList(java.util.List<ListPendingPublishAuditsResponseBodyAuditList> auditList) {
        this.auditList = auditList;
        return this;
    }
    public java.util.List<ListPendingPublishAuditsResponseBodyAuditList> getAuditList() {
        return this.auditList;
    }

    public ListPendingPublishAuditsResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public ListPendingPublishAuditsResponseBody setNextPageToken(String nextPageToken) {
        this.nextPageToken = nextPageToken;
        return this;
    }
    public String getNextPageToken() {
        return this.nextPageToken;
    }

    public static class ListPendingPublishAuditsResponseBodyAuditList extends TeaModel {
        @NameInMap("agentId")
        public String agentId;

        @NameInMap("auditId")
        public String auditId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("sceneType")
        public Integer sceneType;

        @NameInMap("status")
        public Integer status;

        @NameInMap("submitTime")
        public Long submitTime;

        @NameInMap("versionId")
        public String versionId;

        public static ListPendingPublishAuditsResponseBodyAuditList build(java.util.Map<String, ?> map) throws Exception {
            ListPendingPublishAuditsResponseBodyAuditList self = new ListPendingPublishAuditsResponseBodyAuditList();
            return TeaModel.build(map, self);
        }

        public ListPendingPublishAuditsResponseBodyAuditList setAgentId(String agentId) {
            this.agentId = agentId;
            return this;
        }
        public String getAgentId() {
            return this.agentId;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setAuditId(String auditId) {
            this.auditId = auditId;
            return this;
        }
        public String getAuditId() {
            return this.auditId;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setSceneType(Integer sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public Integer getSceneType() {
            return this.sceneType;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setSubmitTime(Long submitTime) {
            this.submitTime = submitTime;
            return this;
        }
        public Long getSubmitTime() {
            return this.submitTime;
        }

        public ListPendingPublishAuditsResponseBodyAuditList setVersionId(String versionId) {
            this.versionId = versionId;
            return this;
        }
        public String getVersionId() {
            return this.versionId;
        }

    }

}
