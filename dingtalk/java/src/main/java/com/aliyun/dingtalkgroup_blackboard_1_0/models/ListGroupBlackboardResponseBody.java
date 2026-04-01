// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class ListGroupBlackboardResponseBody extends TeaModel {
    @NameInMap("blackboardList")
    public java.util.List<ListGroupBlackboardResponseBodyBlackboardList> blackboardList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextPageCursor")
    public String nextPageCursor;

    @NameInMap("success")
    public Boolean success;

    public static ListGroupBlackboardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListGroupBlackboardResponseBody self = new ListGroupBlackboardResponseBody();
        return TeaModel.build(map, self);
    }

    public ListGroupBlackboardResponseBody setBlackboardList(java.util.List<ListGroupBlackboardResponseBodyBlackboardList> blackboardList) {
        this.blackboardList = blackboardList;
        return this;
    }
    public java.util.List<ListGroupBlackboardResponseBodyBlackboardList> getBlackboardList() {
        return this.blackboardList;
    }

    public ListGroupBlackboardResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListGroupBlackboardResponseBody setNextPageCursor(String nextPageCursor) {
        this.nextPageCursor = nextPageCursor;
        return this;
    }
    public String getNextPageCursor() {
        return this.nextPageCursor;
    }

    public ListGroupBlackboardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListGroupBlackboardResponseBodyBlackboardList extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("dataId")
        public String dataId;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("readCount")
        public Integer readCount;

        @NameInMap("sticky")
        public Boolean sticky;

        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static ListGroupBlackboardResponseBodyBlackboardList build(java.util.Map<String, ?> map) throws Exception {
            ListGroupBlackboardResponseBodyBlackboardList self = new ListGroupBlackboardResponseBodyBlackboardList();
            return TeaModel.build(map, self);
        }

        public ListGroupBlackboardResponseBodyBlackboardList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setDataId(String dataId) {
            this.dataId = dataId;
            return this;
        }
        public String getDataId() {
            return this.dataId;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setReadCount(Integer readCount) {
            this.readCount = readCount;
            return this;
        }
        public Integer getReadCount() {
            return this.readCount;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setSticky(Boolean sticky) {
            this.sticky = sticky;
            return this;
        }
        public Boolean getSticky() {
            return this.sticky;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListGroupBlackboardResponseBodyBlackboardList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
