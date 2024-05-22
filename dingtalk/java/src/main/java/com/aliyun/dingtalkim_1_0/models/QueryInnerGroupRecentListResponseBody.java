// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryInnerGroupRecentListResponseBody extends TeaModel {
    @NameInMap("groupInfos")
    public java.util.List<QueryInnerGroupRecentListResponseBodyGroupInfos> groupInfos;

    @NameInMap("success")
    public Boolean success;

    public static QueryInnerGroupRecentListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInnerGroupRecentListResponseBody self = new QueryInnerGroupRecentListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInnerGroupRecentListResponseBody setGroupInfos(java.util.List<QueryInnerGroupRecentListResponseBodyGroupInfos> groupInfos) {
        this.groupInfos = groupInfos;
        return this;
    }
    public java.util.List<QueryInnerGroupRecentListResponseBodyGroupInfos> getGroupInfos() {
        return this.groupInfos;
    }

    public QueryInnerGroupRecentListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryInnerGroupRecentListResponseBodyGroupInfos extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("memberAmount")
        public String memberAmount;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("title")
        public String title;

        public static QueryInnerGroupRecentListResponseBodyGroupInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryInnerGroupRecentListResponseBodyGroupInfos self = new QueryInnerGroupRecentListResponseBodyGroupInfos();
            return TeaModel.build(map, self);
        }

        public QueryInnerGroupRecentListResponseBodyGroupInfos setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryInnerGroupRecentListResponseBodyGroupInfos setMemberAmount(String memberAmount) {
            this.memberAmount = memberAmount;
            return this;
        }
        public String getMemberAmount() {
            return this.memberAmount;
        }

        public QueryInnerGroupRecentListResponseBodyGroupInfos setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QueryInnerGroupRecentListResponseBodyGroupInfos setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
