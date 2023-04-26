// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetNewestInnerGroupsResponseBody extends TeaModel {
    @NameInMap("groupInfos")
    public java.util.List<GetNewestInnerGroupsResponseBodyGroupInfos> groupInfos;

    public static GetNewestInnerGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNewestInnerGroupsResponseBody self = new GetNewestInnerGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNewestInnerGroupsResponseBody setGroupInfos(java.util.List<GetNewestInnerGroupsResponseBodyGroupInfos> groupInfos) {
        this.groupInfos = groupInfos;
        return this;
    }
    public java.util.List<GetNewestInnerGroupsResponseBodyGroupInfos> getGroupInfos() {
        return this.groupInfos;
    }

    public static class GetNewestInnerGroupsResponseBodyGroupInfos extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("memberAmount")
        public String memberAmount;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("title")
        public String title;

        public static GetNewestInnerGroupsResponseBodyGroupInfos build(java.util.Map<String, ?> map) throws Exception {
            GetNewestInnerGroupsResponseBodyGroupInfos self = new GetNewestInnerGroupsResponseBodyGroupInfos();
            return TeaModel.build(map, self);
        }

        public GetNewestInnerGroupsResponseBodyGroupInfos setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public GetNewestInnerGroupsResponseBodyGroupInfos setMemberAmount(String memberAmount) {
            this.memberAmount = memberAmount;
            return this;
        }
        public String getMemberAmount() {
            return this.memberAmount;
        }

        public GetNewestInnerGroupsResponseBodyGroupInfos setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetNewestInnerGroupsResponseBodyGroupInfos setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
