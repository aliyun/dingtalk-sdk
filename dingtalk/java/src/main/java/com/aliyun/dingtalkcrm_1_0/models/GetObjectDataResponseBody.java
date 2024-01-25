// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetObjectDataResponseBody extends TeaModel {
    @NameInMap("result")
    public GetObjectDataResponseBodyResult result;

    public static GetObjectDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetObjectDataResponseBody self = new GetObjectDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetObjectDataResponseBody setResult(GetObjectDataResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetObjectDataResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetObjectDataResponseBodyResultValuesPermission extends TeaModel {
        @NameInMap("ownerUserIds")
        public java.util.List<String> ownerUserIds;

        @NameInMap("participantUserIds")
        public java.util.List<String> participantUserIds;

        public static GetObjectDataResponseBodyResultValuesPermission build(java.util.Map<String, ?> map) throws Exception {
            GetObjectDataResponseBodyResultValuesPermission self = new GetObjectDataResponseBodyResultValuesPermission();
            return TeaModel.build(map, self);
        }

        public GetObjectDataResponseBodyResultValuesPermission setOwnerUserIds(java.util.List<String> ownerUserIds) {
            this.ownerUserIds = ownerUserIds;
            return this;
        }
        public java.util.List<String> getOwnerUserIds() {
            return this.ownerUserIds;
        }

        public GetObjectDataResponseBodyResultValuesPermission setParticipantUserIds(java.util.List<String> participantUserIds) {
            this.participantUserIds = participantUserIds;
            return this;
        }
        public java.util.List<String> getParticipantUserIds() {
            return this.participantUserIds;
        }

    }

    public static class GetObjectDataResponseBodyResultValues extends TeaModel {
        @NameInMap("creatorNick")
        public String creatorNick;

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
        public GetObjectDataResponseBodyResultValuesPermission permission;

        @NameInMap("procInstStatus")
        public String procInstStatus;

        @NameInMap("procOutResult")
        public String procOutResult;

        public static GetObjectDataResponseBodyResultValues build(java.util.Map<String, ?> map) throws Exception {
            GetObjectDataResponseBodyResultValues self = new GetObjectDataResponseBodyResultValues();
            return TeaModel.build(map, self);
        }

        public GetObjectDataResponseBodyResultValues setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public GetObjectDataResponseBodyResultValues setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetObjectDataResponseBodyResultValues setData(java.util.Map<String, String> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, String> getData() {
            return this.data;
        }

        public GetObjectDataResponseBodyResultValues setExtendData(java.util.Map<String, String> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, String> getExtendData() {
            return this.extendData;
        }

        public GetObjectDataResponseBodyResultValues setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetObjectDataResponseBodyResultValues setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetObjectDataResponseBodyResultValues setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public GetObjectDataResponseBodyResultValues setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

        public GetObjectDataResponseBodyResultValues setPermission(GetObjectDataResponseBodyResultValuesPermission permission) {
            this.permission = permission;
            return this;
        }
        public GetObjectDataResponseBodyResultValuesPermission getPermission() {
            return this.permission;
        }

        public GetObjectDataResponseBodyResultValues setProcInstStatus(String procInstStatus) {
            this.procInstStatus = procInstStatus;
            return this;
        }
        public String getProcInstStatus() {
            return this.procInstStatus;
        }

        public GetObjectDataResponseBodyResultValues setProcOutResult(String procOutResult) {
            this.procOutResult = procOutResult;
            return this;
        }
        public String getProcOutResult() {
            return this.procOutResult;
        }

    }

    public static class GetObjectDataResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("values")
        public java.util.List<GetObjectDataResponseBodyResultValues> values;

        public static GetObjectDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetObjectDataResponseBodyResult self = new GetObjectDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetObjectDataResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetObjectDataResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public GetObjectDataResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public GetObjectDataResponseBodyResult setValues(java.util.List<GetObjectDataResponseBodyResultValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<GetObjectDataResponseBodyResultValues> getValues() {
            return this.values;
        }

    }

}
