// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetContactsResponseBody extends TeaModel {
    @NameInMap("result")
    public GetContactsResponseBodyResult result;

    public static GetContactsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContactsResponseBody self = new GetContactsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContactsResponseBody setResult(GetContactsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetContactsResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetContactsResponseBodyResultValuesPermission extends TeaModel {
        @NameInMap("ownerUserIds")
        public java.util.List<String> ownerUserIds;

        @NameInMap("participantUserIds")
        public java.util.List<String> participantUserIds;

        public static GetContactsResponseBodyResultValuesPermission build(java.util.Map<String, ?> map) throws Exception {
            GetContactsResponseBodyResultValuesPermission self = new GetContactsResponseBodyResultValuesPermission();
            return TeaModel.build(map, self);
        }

        public GetContactsResponseBodyResultValuesPermission setOwnerUserIds(java.util.List<String> ownerUserIds) {
            this.ownerUserIds = ownerUserIds;
            return this;
        }
        public java.util.List<String> getOwnerUserIds() {
            return this.ownerUserIds;
        }

        public GetContactsResponseBodyResultValuesPermission setParticipantUserIds(java.util.List<String> participantUserIds) {
            this.participantUserIds = participantUserIds;
            return this;
        }
        public java.util.List<String> getParticipantUserIds() {
            return this.participantUserIds;
        }

    }

    public static class GetContactsResponseBodyResultValues extends TeaModel {
        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("data")
        public java.util.Map<String, String> data;

        @NameInMap("extendData")
        public java.util.Map<String, String> extendData;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("objectType")
        public String objectType;

        @NameInMap("permission")
        public GetContactsResponseBodyResultValuesPermission permission;

        public static GetContactsResponseBodyResultValues build(java.util.Map<String, ?> map) throws Exception {
            GetContactsResponseBodyResultValues self = new GetContactsResponseBodyResultValues();
            return TeaModel.build(map, self);
        }

        public GetContactsResponseBodyResultValues setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetContactsResponseBodyResultValues setData(java.util.Map<String, String> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, String> getData() {
            return this.data;
        }

        public GetContactsResponseBodyResultValues setExtendData(java.util.Map<String, String> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, String> getExtendData() {
            return this.extendData;
        }

        public GetContactsResponseBodyResultValues setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetContactsResponseBodyResultValues setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetContactsResponseBodyResultValues setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public GetContactsResponseBodyResultValues setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

        public GetContactsResponseBodyResultValues setPermission(GetContactsResponseBodyResultValuesPermission permission) {
            this.permission = permission;
            return this;
        }
        public GetContactsResponseBodyResultValuesPermission getPermission() {
            return this.permission;
        }

    }

    public static class GetContactsResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("values")
        public java.util.List<GetContactsResponseBodyResultValues> values;

        public static GetContactsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetContactsResponseBodyResult self = new GetContactsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetContactsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetContactsResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public GetContactsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public GetContactsResponseBodyResult setValues(java.util.List<GetContactsResponseBodyResultValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<GetContactsResponseBodyResultValues> getValues() {
            return this.values;
        }

    }

}
