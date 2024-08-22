// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListVisibleAssistantResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<ListVisibleAssistantResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListVisibleAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListVisibleAssistantResponseBody self = new ListVisibleAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public ListVisibleAssistantResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListVisibleAssistantResponseBody setList(java.util.List<ListVisibleAssistantResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListVisibleAssistantResponseBodyList> getList() {
        return this.list;
    }

    public ListVisibleAssistantResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListVisibleAssistantResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListVisibleAssistantResponseBodyList extends TeaModel {
        @NameInMap("assistantId")
        public String assistantId;

        @NameInMap("createdAt")
        public Long createdAt;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public String icon;

        @NameInMap("name")
        public String name;

        public static ListVisibleAssistantResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListVisibleAssistantResponseBodyList self = new ListVisibleAssistantResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListVisibleAssistantResponseBodyList setAssistantId(String assistantId) {
            this.assistantId = assistantId;
            return this;
        }
        public String getAssistantId() {
            return this.assistantId;
        }

        public ListVisibleAssistantResponseBodyList setCreatedAt(Long createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public Long getCreatedAt() {
            return this.createdAt;
        }

        public ListVisibleAssistantResponseBodyList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public ListVisibleAssistantResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListVisibleAssistantResponseBodyList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListVisibleAssistantResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
