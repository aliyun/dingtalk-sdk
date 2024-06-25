// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SearchInnerGroupsResponseBody extends TeaModel {
    @NameInMap("groupInfos")
    public java.util.List<SearchInnerGroupsResponseBodyGroupInfos> groupInfos;

    public static SearchInnerGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchInnerGroupsResponseBody self = new SearchInnerGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchInnerGroupsResponseBody setGroupInfos(java.util.List<SearchInnerGroupsResponseBodyGroupInfos> groupInfos) {
        this.groupInfos = groupInfos;
        return this;
    }
    public java.util.List<SearchInnerGroupsResponseBodyGroupInfos> getGroupInfos() {
        return this.groupInfos;
    }

    public static class SearchInnerGroupsResponseBodyGroupInfos extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>@lAD*****</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("memberAmount")
        public String memberAmount;

        /**
         * <strong>example:</strong>
         * <p>cid13*****==</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <strong>example:</strong>
         * <p>测试群名称</p>
         */
        @NameInMap("title")
        public String title;

        public static SearchInnerGroupsResponseBodyGroupInfos build(java.util.Map<String, ?> map) throws Exception {
            SearchInnerGroupsResponseBodyGroupInfos self = new SearchInnerGroupsResponseBodyGroupInfos();
            return TeaModel.build(map, self);
        }

        public SearchInnerGroupsResponseBodyGroupInfos setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SearchInnerGroupsResponseBodyGroupInfos setMemberAmount(String memberAmount) {
            this.memberAmount = memberAmount;
            return this;
        }
        public String getMemberAmount() {
            return this.memberAmount;
        }

        public SearchInnerGroupsResponseBodyGroupInfos setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public SearchInnerGroupsResponseBodyGroupInfos setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
