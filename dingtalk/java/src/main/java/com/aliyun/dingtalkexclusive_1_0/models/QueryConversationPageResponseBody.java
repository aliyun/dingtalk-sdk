// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryConversationPageResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryConversationPageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryConversationPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConversationPageResponseBody self = new QueryConversationPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConversationPageResponseBody setResult(QueryConversationPageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryConversationPageResponseBodyResult getResult() {
        return this.result;
    }

    public QueryConversationPageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryConversationPageResponseBodyResultData extends TeaModel {
        @NameInMap("categoryId")
        public Long categoryId;

        /**
         * <strong>example:</strong>
         * <p>未分组</p>
         */
        @NameInMap("categoryName")
        public String categoryName;

        /**
         * <strong>example:</strong>
         * <p>S24A01123</p>
         */
        @NameInMap("groupCode")
        public String groupCode;

        @NameInMap("groupMembersCnt")
        public Integer groupMembersCnt;

        /**
         * <strong>example:</strong>
         * <p>群聊</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <strong>example:</strong>
         * <p>ownername</p>
         */
        @NameInMap("groupOwnerName")
        public String groupOwnerName;

        /**
         * <strong>example:</strong>
         * <p>useridxxx</p>
         */
        @NameInMap("groupOwnerUserId")
        public String groupOwnerUserId;

        @NameInMap("isKpConversation")
        public Boolean isKpConversation;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("manageSign")
        public Integer manageSign;

        /**
         * <strong>example:</strong>
         * <p>cid123xxxxxx</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("order")
        public Integer order;

        @NameInMap("status")
        public Integer status;

        public static QueryConversationPageResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryConversationPageResponseBodyResultData self = new QueryConversationPageResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryConversationPageResponseBodyResultData setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public QueryConversationPageResponseBodyResultData setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public QueryConversationPageResponseBodyResultData setGroupCode(String groupCode) {
            this.groupCode = groupCode;
            return this;
        }
        public String getGroupCode() {
            return this.groupCode;
        }

        public QueryConversationPageResponseBodyResultData setGroupMembersCnt(Integer groupMembersCnt) {
            this.groupMembersCnt = groupMembersCnt;
            return this;
        }
        public Integer getGroupMembersCnt() {
            return this.groupMembersCnt;
        }

        public QueryConversationPageResponseBodyResultData setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryConversationPageResponseBodyResultData setGroupOwnerName(String groupOwnerName) {
            this.groupOwnerName = groupOwnerName;
            return this;
        }
        public String getGroupOwnerName() {
            return this.groupOwnerName;
        }

        public QueryConversationPageResponseBodyResultData setGroupOwnerUserId(String groupOwnerUserId) {
            this.groupOwnerUserId = groupOwnerUserId;
            return this;
        }
        public String getGroupOwnerUserId() {
            return this.groupOwnerUserId;
        }

        public QueryConversationPageResponseBodyResultData setIsKpConversation(Boolean isKpConversation) {
            this.isKpConversation = isKpConversation;
            return this;
        }
        public Boolean getIsKpConversation() {
            return this.isKpConversation;
        }

        public QueryConversationPageResponseBodyResultData setManageSign(Integer manageSign) {
            this.manageSign = manageSign;
            return this;
        }
        public Integer getManageSign() {
            return this.manageSign;
        }

        public QueryConversationPageResponseBodyResultData setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QueryConversationPageResponseBodyResultData setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

        public QueryConversationPageResponseBodyResultData setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class QueryConversationPageResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<QueryConversationPageResponseBodyResultData> data;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <strong>example:</strong>
         * <p>999</p>
         */
        @NameInMap("totalCount")
        public Integer totalCount;

        public static QueryConversationPageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryConversationPageResponseBodyResult self = new QueryConversationPageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryConversationPageResponseBodyResult setData(java.util.List<QueryConversationPageResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<QueryConversationPageResponseBodyResultData> getData() {
            return this.data;
        }

        public QueryConversationPageResponseBodyResult setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public QueryConversationPageResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public QueryConversationPageResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
