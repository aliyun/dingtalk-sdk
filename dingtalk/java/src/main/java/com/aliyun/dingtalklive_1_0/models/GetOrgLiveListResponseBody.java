// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetOrgLiveListResponseBody extends TeaModel {
    @NameInMap("result")
    public GetOrgLiveListResponseBodyResult result;

    public static GetOrgLiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrgLiveListResponseBody self = new GetOrgLiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrgLiveListResponseBody setResult(GetOrgLiveListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetOrgLiveListResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetOrgLiveListResponseBodyResultNewLiveLiveList extends TeaModel {
        @NameInMap("anchorNickname")
        public String anchorNickname;

        @NameInMap("anchorUnionId")
        public String anchorUnionId;

        @NameInMap("liveEndTime")
        public Long liveEndTime;

        @NameInMap("liveStartTime")
        public Long liveStartTime;

        @NameInMap("liveUuid")
        public String liveUuid;

        @NameInMap("shareOpenConversationIds")
        public java.util.List<String> shareOpenConversationIds;

        @NameInMap("title")
        public String title;

        public static GetOrgLiveListResponseBodyResultNewLiveLiveList build(java.util.Map<String, ?> map) throws Exception {
            GetOrgLiveListResponseBodyResultNewLiveLiveList self = new GetOrgLiveListResponseBodyResultNewLiveLiveList();
            return TeaModel.build(map, self);
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setAnchorNickname(String anchorNickname) {
            this.anchorNickname = anchorNickname;
            return this;
        }
        public String getAnchorNickname() {
            return this.anchorNickname;
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setAnchorUnionId(String anchorUnionId) {
            this.anchorUnionId = anchorUnionId;
            return this;
        }
        public String getAnchorUnionId() {
            return this.anchorUnionId;
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setLiveEndTime(Long liveEndTime) {
            this.liveEndTime = liveEndTime;
            return this;
        }
        public Long getLiveEndTime() {
            return this.liveEndTime;
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setLiveStartTime(Long liveStartTime) {
            this.liveStartTime = liveStartTime;
            return this;
        }
        public Long getLiveStartTime() {
            return this.liveStartTime;
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setLiveUuid(String liveUuid) {
            this.liveUuid = liveUuid;
            return this;
        }
        public String getLiveUuid() {
            return this.liveUuid;
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setShareOpenConversationIds(java.util.List<String> shareOpenConversationIds) {
            this.shareOpenConversationIds = shareOpenConversationIds;
            return this;
        }
        public java.util.List<String> getShareOpenConversationIds() {
            return this.shareOpenConversationIds;
        }

        public GetOrgLiveListResponseBodyResultNewLiveLiveList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetOrgLiveListResponseBodyResultNewLive extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("liveList")
        public java.util.List<GetOrgLiveListResponseBodyResultNewLiveLiveList> liveList;

        @NameInMap("pageNumber")
        public Long pageNumber;

        @NameInMap("pageSize")
        public Long pageSize;

        @NameInMap("totalCount")
        public Long totalCount;

        public static GetOrgLiveListResponseBodyResultNewLive build(java.util.Map<String, ?> map) throws Exception {
            GetOrgLiveListResponseBodyResultNewLive self = new GetOrgLiveListResponseBodyResultNewLive();
            return TeaModel.build(map, self);
        }

        public GetOrgLiveListResponseBodyResultNewLive setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetOrgLiveListResponseBodyResultNewLive setLiveList(java.util.List<GetOrgLiveListResponseBodyResultNewLiveLiveList> liveList) {
            this.liveList = liveList;
            return this;
        }
        public java.util.List<GetOrgLiveListResponseBodyResultNewLiveLiveList> getLiveList() {
            return this.liveList;
        }

        public GetOrgLiveListResponseBodyResultNewLive setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public GetOrgLiveListResponseBodyResultNewLive setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public GetOrgLiveListResponseBodyResultNewLive setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

    public static class GetOrgLiveListResponseBodyResultUpdateLiveLiveList extends TeaModel {
        @NameInMap("anchorNickname")
        public String anchorNickname;

        @NameInMap("anchorUnionId")
        public String anchorUnionId;

        @NameInMap("liveEndTime")
        public Long liveEndTime;

        @NameInMap("liveStartTime")
        public Long liveStartTime;

        @NameInMap("liveUuid")
        public String liveUuid;

        @NameInMap("title")
        public String title;

        public static GetOrgLiveListResponseBodyResultUpdateLiveLiveList build(java.util.Map<String, ?> map) throws Exception {
            GetOrgLiveListResponseBodyResultUpdateLiveLiveList self = new GetOrgLiveListResponseBodyResultUpdateLiveLiveList();
            return TeaModel.build(map, self);
        }

        public GetOrgLiveListResponseBodyResultUpdateLiveLiveList setAnchorNickname(String anchorNickname) {
            this.anchorNickname = anchorNickname;
            return this;
        }
        public String getAnchorNickname() {
            return this.anchorNickname;
        }

        public GetOrgLiveListResponseBodyResultUpdateLiveLiveList setAnchorUnionId(String anchorUnionId) {
            this.anchorUnionId = anchorUnionId;
            return this;
        }
        public String getAnchorUnionId() {
            return this.anchorUnionId;
        }

        public GetOrgLiveListResponseBodyResultUpdateLiveLiveList setLiveEndTime(Long liveEndTime) {
            this.liveEndTime = liveEndTime;
            return this;
        }
        public Long getLiveEndTime() {
            return this.liveEndTime;
        }

        public GetOrgLiveListResponseBodyResultUpdateLiveLiveList setLiveStartTime(Long liveStartTime) {
            this.liveStartTime = liveStartTime;
            return this;
        }
        public Long getLiveStartTime() {
            return this.liveStartTime;
        }

        public GetOrgLiveListResponseBodyResultUpdateLiveLiveList setLiveUuid(String liveUuid) {
            this.liveUuid = liveUuid;
            return this;
        }
        public String getLiveUuid() {
            return this.liveUuid;
        }

        public GetOrgLiveListResponseBodyResultUpdateLiveLiveList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetOrgLiveListResponseBodyResultUpdateLive extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("liveList")
        public java.util.List<GetOrgLiveListResponseBodyResultUpdateLiveLiveList> liveList;

        @NameInMap("pageNumber")
        public Long pageNumber;

        @NameInMap("pageSize")
        public Long pageSize;

        @NameInMap("totalCount")
        public Long totalCount;

        public static GetOrgLiveListResponseBodyResultUpdateLive build(java.util.Map<String, ?> map) throws Exception {
            GetOrgLiveListResponseBodyResultUpdateLive self = new GetOrgLiveListResponseBodyResultUpdateLive();
            return TeaModel.build(map, self);
        }

        public GetOrgLiveListResponseBodyResultUpdateLive setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetOrgLiveListResponseBodyResultUpdateLive setLiveList(java.util.List<GetOrgLiveListResponseBodyResultUpdateLiveLiveList> liveList) {
            this.liveList = liveList;
            return this;
        }
        public java.util.List<GetOrgLiveListResponseBodyResultUpdateLiveLiveList> getLiveList() {
            return this.liveList;
        }

        public GetOrgLiveListResponseBodyResultUpdateLive setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public GetOrgLiveListResponseBodyResultUpdateLive setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public GetOrgLiveListResponseBodyResultUpdateLive setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

    public static class GetOrgLiveListResponseBodyResult extends TeaModel {
        @NameInMap("newLive")
        public GetOrgLiveListResponseBodyResultNewLive newLive;

        @NameInMap("updateLive")
        public GetOrgLiveListResponseBodyResultUpdateLive updateLive;

        public static GetOrgLiveListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOrgLiveListResponseBodyResult self = new GetOrgLiveListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOrgLiveListResponseBodyResult setNewLive(GetOrgLiveListResponseBodyResultNewLive newLive) {
            this.newLive = newLive;
            return this;
        }
        public GetOrgLiveListResponseBodyResultNewLive getNewLive() {
            return this.newLive;
        }

        public GetOrgLiveListResponseBodyResult setUpdateLive(GetOrgLiveListResponseBodyResultUpdateLive updateLive) {
            this.updateLive = updateLive;
            return this;
        }
        public GetOrgLiveListResponseBodyResultUpdateLive getUpdateLive() {
            return this.updateLive;
        }

    }

}
