// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupLiveListResponseBody extends TeaModel {
    @NameInMap("result")
    public GetGroupLiveListResponseBodyResult result;

    public static GetGroupLiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupLiveListResponseBody self = new GetGroupLiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupLiveListResponseBody setResult(GetGroupLiveListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetGroupLiveListResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetGroupLiveListResponseBodyResultGroupLiveList extends TeaModel {
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

        public static GetGroupLiveListResponseBodyResultGroupLiveList build(java.util.Map<String, ?> map) throws Exception {
            GetGroupLiveListResponseBodyResultGroupLiveList self = new GetGroupLiveListResponseBodyResultGroupLiveList();
            return TeaModel.build(map, self);
        }

        public GetGroupLiveListResponseBodyResultGroupLiveList setAnchorNickname(String anchorNickname) {
            this.anchorNickname = anchorNickname;
            return this;
        }
        public String getAnchorNickname() {
            return this.anchorNickname;
        }

        public GetGroupLiveListResponseBodyResultGroupLiveList setAnchorUnionId(String anchorUnionId) {
            this.anchorUnionId = anchorUnionId;
            return this;
        }
        public String getAnchorUnionId() {
            return this.anchorUnionId;
        }

        public GetGroupLiveListResponseBodyResultGroupLiveList setLiveEndTime(Long liveEndTime) {
            this.liveEndTime = liveEndTime;
            return this;
        }
        public Long getLiveEndTime() {
            return this.liveEndTime;
        }

        public GetGroupLiveListResponseBodyResultGroupLiveList setLiveStartTime(Long liveStartTime) {
            this.liveStartTime = liveStartTime;
            return this;
        }
        public Long getLiveStartTime() {
            return this.liveStartTime;
        }

        public GetGroupLiveListResponseBodyResultGroupLiveList setLiveUuid(String liveUuid) {
            this.liveUuid = liveUuid;
            return this;
        }
        public String getLiveUuid() {
            return this.liveUuid;
        }

        public GetGroupLiveListResponseBodyResultGroupLiveList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetGroupLiveListResponseBodyResult extends TeaModel {
        @NameInMap("groupLiveList")
        public java.util.List<GetGroupLiveListResponseBodyResultGroupLiveList> groupLiveList;

        public static GetGroupLiveListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetGroupLiveListResponseBodyResult self = new GetGroupLiveListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetGroupLiveListResponseBodyResult setGroupLiveList(java.util.List<GetGroupLiveListResponseBodyResultGroupLiveList> groupLiveList) {
            this.groupLiveList = groupLiveList;
            return this;
        }
        public java.util.List<GetGroupLiveListResponseBodyResultGroupLiveList> getGroupLiveList() {
            return this.groupLiveList;
        }

    }

}
