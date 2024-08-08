// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<ListAssistantResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantResponseBody self = new ListAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAssistantResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListAssistantResponseBody setList(java.util.List<ListAssistantResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListAssistantResponseBodyList> getList() {
        return this.list;
    }

    public ListAssistantResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListAssistantResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListAssistantResponseBodyList extends TeaModel {
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

        public static ListAssistantResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListAssistantResponseBodyList self = new ListAssistantResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListAssistantResponseBodyList setAssistantId(String assistantId) {
            this.assistantId = assistantId;
            return this;
        }
        public String getAssistantId() {
            return this.assistantId;
        }

        public ListAssistantResponseBodyList setCreatedAt(Long createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public Long getCreatedAt() {
            return this.createdAt;
        }

        public ListAssistantResponseBodyList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public ListAssistantResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListAssistantResponseBodyList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListAssistantResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
