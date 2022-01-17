// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatMultiResponseBody extends TeaModel {
    // 客户群列表。
    @NameInMap("result")
    public java.util.List<GetCrmGroupChatMultiResponseBodyResult> result;

    public static GetCrmGroupChatMultiResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatMultiResponseBody self = new GetCrmGroupChatMultiResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatMultiResponseBody setResult(java.util.List<GetCrmGroupChatMultiResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetCrmGroupChatMultiResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetCrmGroupChatMultiResponseBodyResult extends TeaModel {
        // 创建时间(时间戳)。
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        // 群头像地址。
        @NameInMap("iconUrl")
        public String iconUrl;

        // 客户群成员数。
        @NameInMap("memberCount")
        public Integer memberCount;

        // 客户群名
        @NameInMap("name")
        public String name;

        // 客户群openConversationId。
        @NameInMap("openConversationId")
        public String openConversationId;

        // 群组openGroupSetId。
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        // 群主userId。
        @NameInMap("ownerUserId")
        public String ownerUserId;

        // 群主userName。
        @NameInMap("ownerUserName")
        public String ownerUserName;

        public static GetCrmGroupChatMultiResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCrmGroupChatMultiResponseBodyResult self = new GetCrmGroupChatMultiResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCrmGroupChatMultiResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public GetCrmGroupChatMultiResponseBodyResult setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public GetCrmGroupChatMultiResponseBodyResult setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public GetCrmGroupChatMultiResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCrmGroupChatMultiResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetCrmGroupChatMultiResponseBodyResult setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public GetCrmGroupChatMultiResponseBodyResult setOwnerUserId(String ownerUserId) {
            this.ownerUserId = ownerUserId;
            return this;
        }
        public String getOwnerUserId() {
            return this.ownerUserId;
        }

        public GetCrmGroupChatMultiResponseBodyResult setOwnerUserName(String ownerUserName) {
            this.ownerUserName = ownerUserName;
            return this;
        }
        public String getOwnerUserName() {
            return this.ownerUserName;
        }

    }

}
