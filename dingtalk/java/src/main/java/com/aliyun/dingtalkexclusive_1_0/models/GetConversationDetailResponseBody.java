// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConversationDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public GetConversationDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetConversationDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationDetailResponseBody self = new GetConversationDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationDetailResponseBody setResult(GetConversationDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetConversationDetailResponseBodyResult getResult() {
        return this.result;
    }

    public GetConversationDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetConversationDetailResponseBodyResultMultipleCategoryList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("categoryId")
        public Long categoryId;

        /**
         * <strong>example:</strong>
         * <p>全部</p>
         */
        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("order")
        public Integer order;

        public static GetConversationDetailResponseBodyResultMultipleCategoryList build(java.util.Map<String, ?> map) throws Exception {
            GetConversationDetailResponseBodyResultMultipleCategoryList self = new GetConversationDetailResponseBodyResultMultipleCategoryList();
            return TeaModel.build(map, self);
        }

        public GetConversationDetailResponseBodyResultMultipleCategoryList setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public GetConversationDetailResponseBodyResultMultipleCategoryList setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public GetConversationDetailResponseBodyResultMultipleCategoryList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class GetConversationDetailResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>-1</p>
         */
        @NameInMap("categoryId")
        public Long categoryId;

        /**
         * <strong>example:</strong>
         * <p>categoryName</p>
         */
        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("groupCode")
        public String groupCode;

        /**
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("groupMembersCnt")
        public Integer groupMembersCnt;

        /**
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <strong>example:</strong>
         * <p>groupOwnerName</p>
         */
        @NameInMap("groupOwnerName")
        public String groupOwnerName;

        /**
         * <strong>example:</strong>
         * <p>groupOwnerUserId</p>
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

        @NameInMap("multipleCategoryList")
        public java.util.List<GetConversationDetailResponseBodyResultMultipleCategoryList> multipleCategoryList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>cidxxx</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("order")
        public Integer order;

        @NameInMap("status")
        public Integer status;

        public static GetConversationDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetConversationDetailResponseBodyResult self = new GetConversationDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetConversationDetailResponseBodyResult setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public GetConversationDetailResponseBodyResult setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public GetConversationDetailResponseBodyResult setGroupCode(String groupCode) {
            this.groupCode = groupCode;
            return this;
        }
        public String getGroupCode() {
            return this.groupCode;
        }

        public GetConversationDetailResponseBodyResult setGroupMembersCnt(Integer groupMembersCnt) {
            this.groupMembersCnt = groupMembersCnt;
            return this;
        }
        public Integer getGroupMembersCnt() {
            return this.groupMembersCnt;
        }

        public GetConversationDetailResponseBodyResult setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetConversationDetailResponseBodyResult setGroupOwnerName(String groupOwnerName) {
            this.groupOwnerName = groupOwnerName;
            return this;
        }
        public String getGroupOwnerName() {
            return this.groupOwnerName;
        }

        public GetConversationDetailResponseBodyResult setGroupOwnerUserId(String groupOwnerUserId) {
            this.groupOwnerUserId = groupOwnerUserId;
            return this;
        }
        public String getGroupOwnerUserId() {
            return this.groupOwnerUserId;
        }

        public GetConversationDetailResponseBodyResult setIsKpConversation(Boolean isKpConversation) {
            this.isKpConversation = isKpConversation;
            return this;
        }
        public Boolean getIsKpConversation() {
            return this.isKpConversation;
        }

        public GetConversationDetailResponseBodyResult setManageSign(Integer manageSign) {
            this.manageSign = manageSign;
            return this;
        }
        public Integer getManageSign() {
            return this.manageSign;
        }

        public GetConversationDetailResponseBodyResult setMultipleCategoryList(java.util.List<GetConversationDetailResponseBodyResultMultipleCategoryList> multipleCategoryList) {
            this.multipleCategoryList = multipleCategoryList;
            return this;
        }
        public java.util.List<GetConversationDetailResponseBodyResultMultipleCategoryList> getMultipleCategoryList() {
            return this.multipleCategoryList;
        }

        public GetConversationDetailResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetConversationDetailResponseBodyResult setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

        public GetConversationDetailResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
