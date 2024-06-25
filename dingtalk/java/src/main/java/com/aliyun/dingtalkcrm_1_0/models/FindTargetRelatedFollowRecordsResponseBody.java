// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class FindTargetRelatedFollowRecordsResponseBody extends TeaModel {
    @NameInMap("result")
    public FindTargetRelatedFollowRecordsResponseBodyResult result;

    public static FindTargetRelatedFollowRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FindTargetRelatedFollowRecordsResponseBody self = new FindTargetRelatedFollowRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public FindTargetRelatedFollowRecordsResponseBody setResult(FindTargetRelatedFollowRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public FindTargetRelatedFollowRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public static class FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>follow_record_related_content</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <strong>example:</strong>
         * <p>扩展value</p>
         */
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <strong>example:</strong>
         * <p>TextareaField-K2U5UJAF</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>重点跟进</p>
         */
        @NameInMap("value")
        public String value;

        public static FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent build(java.util.Map<String, ?> map) throws Exception {
            FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent self = new FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent();
            return TeaModel.build(map, self);
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class FindTargetRelatedFollowRecordsResponseBodyResultResultList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>manager7617</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("followContent")
        public java.util.List<FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent> followContent;

        /**
         * <strong>example:</strong>
         * <p>customerId</p>
         */
        @NameInMap("followTargetDataId")
        public String followTargetDataId;

        /**
         * <strong>example:</strong>
         * <p>customer</p>
         */
        @NameInMap("followTargetType")
        public String followTargetType;

        /**
         * <strong>example:</strong>
         * <p>1712629910168</p>
         */
        @NameInMap("gmtCreateMilliseconds")
        public String gmtCreateMilliseconds;

        /**
         * <strong>example:</strong>
         * <p>1712629910168</p>
         */
        @NameInMap("gmtModifiedMilliseconds")
        public String gmtModifiedMilliseconds;

        /**
         * <strong>example:</strong>
         * <p>manager7617</p>
         */
        @NameInMap("modifierUserId")
        public String modifierUserId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>_aFFogIuRrWlL3hLdvbb5w09951712629910</p>
         */
        @NameInMap("recordInstId")
        public String recordInstId;

        public static FindTargetRelatedFollowRecordsResponseBodyResultResultList build(java.util.Map<String, ?> map) throws Exception {
            FindTargetRelatedFollowRecordsResponseBodyResultResultList self = new FindTargetRelatedFollowRecordsResponseBodyResultResultList();
            return TeaModel.build(map, self);
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setFollowContent(java.util.List<FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent> followContent) {
            this.followContent = followContent;
            return this;
        }
        public java.util.List<FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent> getFollowContent() {
            return this.followContent;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setFollowTargetDataId(String followTargetDataId) {
            this.followTargetDataId = followTargetDataId;
            return this;
        }
        public String getFollowTargetDataId() {
            return this.followTargetDataId;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setFollowTargetType(String followTargetType) {
            this.followTargetType = followTargetType;
            return this;
        }
        public String getFollowTargetType() {
            return this.followTargetType;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setGmtCreateMilliseconds(String gmtCreateMilliseconds) {
            this.gmtCreateMilliseconds = gmtCreateMilliseconds;
            return this;
        }
        public String getGmtCreateMilliseconds() {
            return this.gmtCreateMilliseconds;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setGmtModifiedMilliseconds(String gmtModifiedMilliseconds) {
            this.gmtModifiedMilliseconds = gmtModifiedMilliseconds;
            return this;
        }
        public String getGmtModifiedMilliseconds() {
            return this.gmtModifiedMilliseconds;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setModifierUserId(String modifierUserId) {
            this.modifierUserId = modifierUserId;
            return this;
        }
        public String getModifierUserId() {
            return this.modifierUserId;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResultResultList setRecordInstId(String recordInstId) {
            this.recordInstId = recordInstId;
            return this;
        }
        public String getRecordInstId() {
            return this.recordInstId;
        }

    }

    public static class FindTargetRelatedFollowRecordsResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <strong>example:</strong>
         * <p>1000</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("resultList")
        public java.util.List<FindTargetRelatedFollowRecordsResponseBodyResultResultList> resultList;

        public static FindTargetRelatedFollowRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            FindTargetRelatedFollowRecordsResponseBodyResult self = new FindTargetRelatedFollowRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public FindTargetRelatedFollowRecordsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public FindTargetRelatedFollowRecordsResponseBodyResult setResultList(java.util.List<FindTargetRelatedFollowRecordsResponseBodyResultResultList> resultList) {
            this.resultList = resultList;
            return this;
        }
        public java.util.List<FindTargetRelatedFollowRecordsResponseBodyResultResultList> getResultList() {
            return this.resultList;
        }

    }

}
