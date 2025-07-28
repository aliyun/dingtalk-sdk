// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByAppCidsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupInfoList")
    public java.util.List<QueryGroupInfoByAppCidsResponseBodyGroupInfoList> groupInfoList;

    public static QueryGroupInfoByAppCidsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByAppCidsResponseBody self = new QueryGroupInfoByAppCidsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByAppCidsResponseBody setGroupInfoList(java.util.List<QueryGroupInfoByAppCidsResponseBodyGroupInfoList> groupInfoList) {
        this.groupInfoList = groupInfoList;
        return this;
    }
    public java.util.List<QueryGroupInfoByAppCidsResponseBodyGroupInfoList> getGroupInfoList() {
        return this.groupInfoList;
    }

    public static class QueryGroupInfoByAppCidsResponseBodyGroupInfoList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>$2$123456$2</p>
         */
        @NameInMap("appCid")
        public String appCid;

        /**
         * <strong>example:</strong>
         * <p>ding1234</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>@abc</p>
         */
        @NameInMap("groupAvatar")
        public String groupAvatar;

        /**
         * <strong>example:</strong>
         * <p><a href="https://abc">https://abc</a></p>
         */
        @NameInMap("groupAvatarUrl")
        public String groupAvatarUrl;

        /**
         * <strong>example:</strong>
         * <p>群名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <strong>example:</strong>
         * <p>123456a==</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        public static QueryGroupInfoByAppCidsResponseBodyGroupInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoByAppCidsResponseBodyGroupInfoList self = new QueryGroupInfoByAppCidsResponseBodyGroupInfoList();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoByAppCidsResponseBodyGroupInfoList setAppCid(String appCid) {
            this.appCid = appCid;
            return this;
        }
        public String getAppCid() {
            return this.appCid;
        }

        public QueryGroupInfoByAppCidsResponseBodyGroupInfoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryGroupInfoByAppCidsResponseBodyGroupInfoList setGroupAvatar(String groupAvatar) {
            this.groupAvatar = groupAvatar;
            return this;
        }
        public String getGroupAvatar() {
            return this.groupAvatar;
        }

        public QueryGroupInfoByAppCidsResponseBodyGroupInfoList setGroupAvatarUrl(String groupAvatarUrl) {
            this.groupAvatarUrl = groupAvatarUrl;
            return this;
        }
        public String getGroupAvatarUrl() {
            return this.groupAvatarUrl;
        }

        public QueryGroupInfoByAppCidsResponseBodyGroupInfoList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryGroupInfoByAppCidsResponseBodyGroupInfoList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
