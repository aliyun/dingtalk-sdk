// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgPointDetailsResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryOrgPointDetailsResponseBodyResult result;

    public static QueryOrgPointDetailsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgPointDetailsResponseBody self = new QueryOrgPointDetailsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgPointDetailsResponseBody setResult(QueryOrgPointDetailsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOrgPointDetailsResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("empName")
        public String empName;

        @NameInMap("userId")
        public String userId;

        public static QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource self = new QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource();
            return TeaModel.build(map, self);
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource setEmpName(String empName) {
            this.empName = empName;
            return this;
        }
        public String getEmpName() {
            return this.empName;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget extends TeaModel {
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("empName")
        public String empName;

        @NameInMap("userId")
        public String userId;

        public static QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget self = new QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget();
            return TeaModel.build(map, self);
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget setEmpName(String empName) {
            this.empName = empName;
            return this;
        }
        public String getEmpName() {
            return this.empName;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO extends TeaModel {
        @NameInMap("accountSource")
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource accountSource;

        @NameInMap("accountTarget")
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget accountTarget;

        @NameInMap("remark")
        public String remark;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("usage")
        public String usage;

        public static QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO self = new QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO();
            return TeaModel.build(map, self);
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setAccountSource(QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource accountSource) {
            this.accountSource = accountSource;
            return this;
        }
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource getAccountSource() {
            return this.accountSource;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setAccountTarget(QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget accountTarget) {
            this.accountTarget = accountTarget;
            return this;
        }
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget getAccountTarget() {
            return this.accountTarget;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setUsage(String usage) {
            this.usage = usage;
            return this;
        }
        public String getUsage() {
            return this.usage;
        }

    }

    public static class QueryOrgPointDetailsResponseBodyResultDetails extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("amount")
        public Long amount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("outId")
        public String outId;

        @NameInMap("pointOperateFeatureResponseDTO")
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO pointOperateFeatureResponseDTO;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sourceBizCode")
        public String sourceBizCode;

        public static QueryOrgPointDetailsResponseBodyResultDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgPointDetailsResponseBodyResultDetails self = new QueryOrgPointDetailsResponseBodyResultDetails();
            return TeaModel.build(map, self);
        }

        public QueryOrgPointDetailsResponseBodyResultDetails setAmount(Long amount) {
            this.amount = amount;
            return this;
        }
        public Long getAmount() {
            return this.amount;
        }

        public QueryOrgPointDetailsResponseBodyResultDetails setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryOrgPointDetailsResponseBodyResultDetails setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public QueryOrgPointDetailsResponseBodyResultDetails setPointOperateFeatureResponseDTO(QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO pointOperateFeatureResponseDTO) {
            this.pointOperateFeatureResponseDTO = pointOperateFeatureResponseDTO;
            return this;
        }
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO getPointOperateFeatureResponseDTO() {
            return this.pointOperateFeatureResponseDTO;
        }

        public QueryOrgPointDetailsResponseBodyResultDetails setSourceBizCode(String sourceBizCode) {
            this.sourceBizCode = sourceBizCode;
            return this;
        }
        public String getSourceBizCode() {
            return this.sourceBizCode;
        }

    }

    public static class QueryOrgPointDetailsResponseBodyResult extends TeaModel {
        @NameInMap("details")
        public java.util.List<QueryOrgPointDetailsResponseBodyResultDetails> details;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static QueryOrgPointDetailsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgPointDetailsResponseBodyResult self = new QueryOrgPointDetailsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOrgPointDetailsResponseBodyResult setDetails(java.util.List<QueryOrgPointDetailsResponseBodyResultDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<QueryOrgPointDetailsResponseBodyResultDetails> getDetails() {
            return this.details;
        }

        public QueryOrgPointDetailsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryOrgPointDetailsResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
