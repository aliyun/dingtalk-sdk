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
        // 积分账号的类型
        // 企业账号：ORG, 员工账号：EMP
        @NameInMap("accountType")
        public String accountType;

        // 企业内名字
        @NameInMap("empName")
        public String empName;

        // 用户id
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
        // 积分账号的类型
        // 企业账号：ORG, 员工账号：EMP
        @NameInMap("accountType")
        public String accountType;

        // 企业内名字
        @NameInMap("empName")
        public String empName;

        // 用户id
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
        // 如果是扣减操作明细，为被扣减账户
        // 如果是发放操作明细，为操作发放账户
        // 如果是个人积分明细，为来源账户
        @NameInMap("accountSource")
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource accountSource;

        // 如果是扣减操作明细，为操作扣减账户
        // 如果是发放操作明细，为被发放账户
        // 如果是个人积分明细，为目标账户
        @NameInMap("accountTarget")
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget accountTarget;

        // 备注信息，在明细中展示
        @NameInMap("remark")
        public String remark;

        // 来源/用途 一般是系统固定的场景
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
        // 积分数量 发放时为负。 扣减时为正
        @NameInMap("amount")
        public Long amount;

        // 创建时间
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        // 积分交易单号
        @NameInMap("outId")
        public String outId;

        // 账户信息
        @NameInMap("pointOperateFeatureResponseDTO")
        public QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO pointOperateFeatureResponseDTO;

        // 源账户积分bizCode。
        // 个人可用积分:personal
        // 额度:credit
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
        // 积分明细列表
        @NameInMap("details")
        public java.util.List<QueryOrgPointDetailsResponseBodyResultDetails> details;

        // 分页使用，表示是否还有下一页
        @NameInMap("hasMore")
        public Boolean hasMore;

        // 调用是否成功
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
