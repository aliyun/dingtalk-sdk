// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByOpenCidsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupInfoList")
    public java.util.List<QueryGroupInfoByOpenCidsResponseBodyGroupInfoList> groupInfoList;

    public static QueryGroupInfoByOpenCidsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByOpenCidsResponseBody self = new QueryGroupInfoByOpenCidsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByOpenCidsResponseBody setGroupInfoList(java.util.List<QueryGroupInfoByOpenCidsResponseBodyGroupInfoList> groupInfoList) {
        this.groupInfoList = groupInfoList;
        return this;
    }
    public java.util.List<QueryGroupInfoByOpenCidsResponseBodyGroupInfoList> getGroupInfoList() {
        return this.groupInfoList;
    }

    public static class QueryGroupInfoByOpenCidsResponseBodyGroupInfoList extends TeaModel {
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

        public static QueryGroupInfoByOpenCidsResponseBodyGroupInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoByOpenCidsResponseBodyGroupInfoList self = new QueryGroupInfoByOpenCidsResponseBodyGroupInfoList();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoByOpenCidsResponseBodyGroupInfoList setAppCid(String appCid) {
            this.appCid = appCid;
            return this;
        }
        public String getAppCid() {
            return this.appCid;
        }

        public QueryGroupInfoByOpenCidsResponseBodyGroupInfoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryGroupInfoByOpenCidsResponseBodyGroupInfoList setGroupAvatar(String groupAvatar) {
            this.groupAvatar = groupAvatar;
            return this;
        }
        public String getGroupAvatar() {
            return this.groupAvatar;
        }

        public QueryGroupInfoByOpenCidsResponseBodyGroupInfoList setGroupAvatarUrl(String groupAvatarUrl) {
            this.groupAvatarUrl = groupAvatarUrl;
            return this;
        }
        public String getGroupAvatarUrl() {
            return this.groupAvatarUrl;
        }

        public QueryGroupInfoByOpenCidsResponseBodyGroupInfoList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryGroupInfoByOpenCidsResponseBodyGroupInfoList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
