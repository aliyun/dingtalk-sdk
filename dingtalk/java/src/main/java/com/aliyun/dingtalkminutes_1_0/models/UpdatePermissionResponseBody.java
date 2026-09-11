// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionResponseBody extends TeaModel {
    @NameInMap("allSucceeded")
    public Boolean allSucceeded;

    @NameInMap("failMemberInfoList")
    public java.util.List<UpdatePermissionResponseBodyFailMemberInfoList> failMemberInfoList;

    @NameInMap("memberPermissionOperationResults")
    public java.util.List<UpdatePermissionResponseBodyMemberPermissionOperationResults> memberPermissionOperationResults;

    /**
     * <strong>example:</strong>
     * <p>v2</p>
     */
    @NameInMap("modelVersion")
    public String modelVersion;

    @NameInMap("partialSuccess")
    public Boolean partialSuccess;

    @NameInMap("shareScopeResult")
    public UpdatePermissionResponseBodyShareScopeResult shareScopeResult;

    public static UpdatePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionResponseBody self = new UpdatePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionResponseBody setAllSucceeded(Boolean allSucceeded) {
        this.allSucceeded = allSucceeded;
        return this;
    }
    public Boolean getAllSucceeded() {
        return this.allSucceeded;
    }

    public UpdatePermissionResponseBody setFailMemberInfoList(java.util.List<UpdatePermissionResponseBodyFailMemberInfoList> failMemberInfoList) {
        this.failMemberInfoList = failMemberInfoList;
        return this;
    }
    public java.util.List<UpdatePermissionResponseBodyFailMemberInfoList> getFailMemberInfoList() {
        return this.failMemberInfoList;
    }

    public UpdatePermissionResponseBody setMemberPermissionOperationResults(java.util.List<UpdatePermissionResponseBodyMemberPermissionOperationResults> memberPermissionOperationResults) {
        this.memberPermissionOperationResults = memberPermissionOperationResults;
        return this;
    }
    public java.util.List<UpdatePermissionResponseBodyMemberPermissionOperationResults> getMemberPermissionOperationResults() {
        return this.memberPermissionOperationResults;
    }

    public UpdatePermissionResponseBody setModelVersion(String modelVersion) {
        this.modelVersion = modelVersion;
        return this;
    }
    public String getModelVersion() {
        return this.modelVersion;
    }

    public UpdatePermissionResponseBody setPartialSuccess(Boolean partialSuccess) {
        this.partialSuccess = partialSuccess;
        return this;
    }
    public Boolean getPartialSuccess() {
        return this.partialSuccess;
    }

    public UpdatePermissionResponseBody setShareScopeResult(UpdatePermissionResponseBodyShareScopeResult shareScopeResult) {
        this.shareScopeResult = shareScopeResult;
        return this;
    }
    public UpdatePermissionResponseBodyShareScopeResult getShareScopeResult() {
        return this.shareScopeResult;
    }

    public static class UpdatePermissionResponseBodyFailMemberInfoList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <strong>example:</strong>
         * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
         */
        @NameInMap("memberUnionId")
        public String memberUnionId;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("policyId")
        public Long policyId;

        public static UpdatePermissionResponseBodyFailMemberInfoList build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionResponseBodyFailMemberInfoList self = new UpdatePermissionResponseBodyFailMemberInfoList();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionResponseBodyFailMemberInfoList setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public UpdatePermissionResponseBodyFailMemberInfoList setMemberUnionId(String memberUnionId) {
            this.memberUnionId = memberUnionId;
            return this;
        }
        public String getMemberUnionId() {
            return this.memberUnionId;
        }

        public UpdatePermissionResponseBodyFailMemberInfoList setPolicyId(Long policyId) {
            this.policyId = policyId;
            return this;
        }
        public Long getPolicyId() {
            return this.policyId;
        }

    }

    public static class UpdatePermissionResponseBodyMemberPermissionOperationResults extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMessage")
        public String errorMessage;

        @NameInMap("index")
        public Integer index;

        @NameInMap("memberType")
        public Integer memberType;

        @NameInMap("memberUnionId")
        public String memberUnionId;

        @NameInMap("opType")
        public Integer opType;

        @NameInMap("policyId")
        public Long policyId;

        @NameInMap("success")
        public Boolean success;

        public static UpdatePermissionResponseBodyMemberPermissionOperationResults build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionResponseBodyMemberPermissionOperationResults self = new UpdatePermissionResponseBodyMemberPermissionOperationResults();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setErrorMessage(String errorMessage) {
            this.errorMessage = errorMessage;
            return this;
        }
        public String getErrorMessage() {
            return this.errorMessage;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setIndex(Integer index) {
            this.index = index;
            return this;
        }
        public Integer getIndex() {
            return this.index;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setMemberUnionId(String memberUnionId) {
            this.memberUnionId = memberUnionId;
            return this;
        }
        public String getMemberUnionId() {
            return this.memberUnionId;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setOpType(Integer opType) {
            this.opType = opType;
            return this;
        }
        public Integer getOpType() {
            return this.opType;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setPolicyId(Long policyId) {
            this.policyId = policyId;
            return this;
        }
        public Long getPolicyId() {
            return this.policyId;
        }

        public UpdatePermissionResponseBodyMemberPermissionOperationResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class UpdatePermissionResponseBodyShareScopeResult extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMessage")
        public String errorMessage;

        @NameInMap("success")
        public Boolean success;

        public static UpdatePermissionResponseBodyShareScopeResult build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionResponseBodyShareScopeResult self = new UpdatePermissionResponseBodyShareScopeResult();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionResponseBodyShareScopeResult setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public UpdatePermissionResponseBodyShareScopeResult setErrorMessage(String errorMessage) {
            this.errorMessage = errorMessage;
            return this;
        }
        public String getErrorMessage() {
            return this.errorMessage;
        }

        public UpdatePermissionResponseBodyShareScopeResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
