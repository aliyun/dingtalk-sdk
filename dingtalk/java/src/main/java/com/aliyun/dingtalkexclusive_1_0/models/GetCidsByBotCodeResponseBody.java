// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCidsByBotCodeResponseBody extends TeaModel {
    @NameInMap("groupInfos")
    public java.util.List<GetCidsByBotCodeResponseBodyGroupInfos> groupInfos;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static GetCidsByBotCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCidsByBotCodeResponseBody self = new GetCidsByBotCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCidsByBotCodeResponseBody setGroupInfos(java.util.List<GetCidsByBotCodeResponseBodyGroupInfos> groupInfos) {
        this.groupInfos = groupInfos;
        return this;
    }
    public java.util.List<GetCidsByBotCodeResponseBodyGroupInfos> getGroupInfos() {
        return this.groupInfos;
    }

    public GetCidsByBotCodeResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class GetCidsByBotCodeResponseBodyGroupInfos extends TeaModel {
        @NameInMap("botCreator")
        public String botCreator;

        @NameInMap("botCreatorIsOrgMember")
        public Boolean botCreatorIsOrgMember;

        @NameInMap("openConversationId")
        public String openConversationId;

        public static GetCidsByBotCodeResponseBodyGroupInfos build(java.util.Map<String, ?> map) throws Exception {
            GetCidsByBotCodeResponseBodyGroupInfos self = new GetCidsByBotCodeResponseBodyGroupInfos();
            return TeaModel.build(map, self);
        }

        public GetCidsByBotCodeResponseBodyGroupInfos setBotCreator(String botCreator) {
            this.botCreator = botCreator;
            return this;
        }
        public String getBotCreator() {
            return this.botCreator;
        }

        public GetCidsByBotCodeResponseBodyGroupInfos setBotCreatorIsOrgMember(Boolean botCreatorIsOrgMember) {
            this.botCreatorIsOrgMember = botCreatorIsOrgMember;
            return this;
        }
        public Boolean getBotCreatorIsOrgMember() {
            return this.botCreatorIsOrgMember;
        }

        public GetCidsByBotCodeResponseBodyGroupInfos setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
