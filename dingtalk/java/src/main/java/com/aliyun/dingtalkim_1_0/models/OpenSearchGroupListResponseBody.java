// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenSearchGroupListResponseBody extends TeaModel {
    @NameInMap("result")
    public OpenSearchGroupListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static OpenSearchGroupListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenSearchGroupListResponseBody self = new OpenSearchGroupListResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenSearchGroupListResponseBody setResult(OpenSearchGroupListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OpenSearchGroupListResponseBodyResult getResult() {
        return this.result;
    }

    public OpenSearchGroupListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OpenSearchGroupListResponseBodyResultGroupList extends TeaModel {
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

        public static OpenSearchGroupListResponseBodyResultGroupList build(java.util.Map<String, ?> map) throws Exception {
            OpenSearchGroupListResponseBodyResultGroupList self = new OpenSearchGroupListResponseBodyResultGroupList();
            return TeaModel.build(map, self);
        }

        public OpenSearchGroupListResponseBodyResultGroupList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public OpenSearchGroupListResponseBodyResultGroupList setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public OpenSearchGroupListResponseBodyResultGroupList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public OpenSearchGroupListResponseBodyResultGroupList setTag(String tag) {
            this.tag = tag;
            return this;
        }
        public String getTag() {
            return this.tag;
        }

        public OpenSearchGroupListResponseBodyResultGroupList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class OpenSearchGroupListResponseBodyResult extends TeaModel {
        @NameInMap("groupList")
        public java.util.List<OpenSearchGroupListResponseBodyResultGroupList> groupList;

        public static OpenSearchGroupListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OpenSearchGroupListResponseBodyResult self = new OpenSearchGroupListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OpenSearchGroupListResponseBodyResult setGroupList(java.util.List<OpenSearchGroupListResponseBodyResultGroupList> groupList) {
            this.groupList = groupList;
            return this;
        }
        public java.util.List<OpenSearchGroupListResponseBodyResultGroupList> getGroupList() {
            return this.groupList;
        }

    }

}
