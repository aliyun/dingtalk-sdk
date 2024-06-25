// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryOpenGroupBaseInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryOpenGroupBaseInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOpenGroupBaseInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOpenGroupBaseInfoResponseBody self = new QueryOpenGroupBaseInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOpenGroupBaseInfoResponseBody setResult(QueryOpenGroupBaseInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOpenGroupBaseInfoResponseBodyResult getResult() {
        return this.result;
    }

    public QueryOpenGroupBaseInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOpenGroupBaseInfoResponseBodyResult extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("memberCount")
        public Integer memberCount;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("tag")
        public String tag;

        @NameInMap("title")
        public String title;

        public static QueryOpenGroupBaseInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOpenGroupBaseInfoResponseBodyResult self = new QueryOpenGroupBaseInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOpenGroupBaseInfoResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryOpenGroupBaseInfoResponseBodyResult setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public QueryOpenGroupBaseInfoResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QueryOpenGroupBaseInfoResponseBodyResult setTag(String tag) {
            this.tag = tag;
            return this;
        }
        public String getTag() {
            return this.tag;
        }

        public QueryOpenGroupBaseInfoResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
