// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryEmpPointDetailsResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryEmpPointDetailsResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static QueryEmpPointDetailsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEmpPointDetailsResponseBody self = new QueryEmpPointDetailsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEmpPointDetailsResponseBody setResult(QueryEmpPointDetailsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryEmpPointDetailsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryEmpPointDetailsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>EMP</p>
         */
        @NameInMap("accountType")
        public String accountType;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("empName")
        public String empName;

        /**
         * <strong>example:</strong>
         * <p>01274411491620908910</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource build(java.util.Map<String, ?> map) throws Exception {
            QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource self = new QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource();
            return TeaModel.build(map, self);
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource setEmpName(String empName) {
            this.empName = empName;
            return this;
        }
        public String getEmpName() {
            return this.empName;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>personal</p>
         */
        @NameInMap("accountType")
        public String accountType;

        /**
         * <strong>example:</strong>
         * <p>李四</p>
         */
        @NameInMap("empName")
        public String empName;

        /**
         * <strong>example:</strong>
         * <p>01274411491620908910</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget build(java.util.Map<String, ?> map) throws Exception {
            QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget self = new QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget();
            return TeaModel.build(map, self);
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget setEmpName(String empName) {
            this.empName = empName;
            return this;
        }
        public String getEmpName() {
            return this.empName;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO extends TeaModel {
        @NameInMap("accountSource")
        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource accountSource;

        @NameInMap("accountTarget")
        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget accountTarget;

        /**
         * <strong>example:</strong>
         * <p>收到奖励积分</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>三方系统员工收到积分</p>
         */
        @NameInMap("usage")
        public String usage;

        public static QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO self = new QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO();
            return TeaModel.build(map, self);
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setAccountSource(QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource accountSource) {
            this.accountSource = accountSource;
            return this;
        }
        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource getAccountSource() {
            return this.accountSource;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setAccountTarget(QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget accountTarget) {
            this.accountTarget = accountTarget;
            return this;
        }
        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget getAccountTarget() {
            return this.accountTarget;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO setUsage(String usage) {
            this.usage = usage;
            return this;
        }
        public String getUsage() {
            return this.usage;
        }

    }

    public static class QueryEmpPointDetailsResponseBodyResultDetails extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("amount")
        public Long amount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1655450856000</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>324324353535</p>
         */
        @NameInMap("outId")
        public String outId;

        @NameInMap("pointOperateFeatureResponseDTO")
        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO pointOperateFeatureResponseDTO;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>personal</p>
         */
        @NameInMap("sourceBizCode")
        public String sourceBizCode;

        public static QueryEmpPointDetailsResponseBodyResultDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryEmpPointDetailsResponseBodyResultDetails self = new QueryEmpPointDetailsResponseBodyResultDetails();
            return TeaModel.build(map, self);
        }

        public QueryEmpPointDetailsResponseBodyResultDetails setAmount(Long amount) {
            this.amount = amount;
            return this;
        }
        public Long getAmount() {
            return this.amount;
        }

        public QueryEmpPointDetailsResponseBodyResultDetails setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryEmpPointDetailsResponseBodyResultDetails setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public QueryEmpPointDetailsResponseBodyResultDetails setPointOperateFeatureResponseDTO(QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO pointOperateFeatureResponseDTO) {
            this.pointOperateFeatureResponseDTO = pointOperateFeatureResponseDTO;
            return this;
        }
        public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO getPointOperateFeatureResponseDTO() {
            return this.pointOperateFeatureResponseDTO;
        }

        public QueryEmpPointDetailsResponseBodyResultDetails setSourceBizCode(String sourceBizCode) {
            this.sourceBizCode = sourceBizCode;
            return this;
        }
        public String getSourceBizCode() {
            return this.sourceBizCode;
        }

    }

    public static class QueryEmpPointDetailsResponseBodyResult extends TeaModel {
        @NameInMap("details")
        public java.util.List<QueryEmpPointDetailsResponseBodyResultDetails> details;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        public static QueryEmpPointDetailsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryEmpPointDetailsResponseBodyResult self = new QueryEmpPointDetailsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryEmpPointDetailsResponseBodyResult setDetails(java.util.List<QueryEmpPointDetailsResponseBodyResultDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<QueryEmpPointDetailsResponseBodyResultDetails> getDetails() {
            return this.details;
        }

        public QueryEmpPointDetailsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

    }

}
