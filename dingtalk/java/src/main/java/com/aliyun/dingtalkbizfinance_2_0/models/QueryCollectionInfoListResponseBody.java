// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCollectionInfoListResponseBody extends TeaModel {
    @NameInMap("collectionInfoList")
    public java.util.List<QueryCollectionInfoListResponseBodyCollectionInfoList> collectionInfoList;

    public static QueryCollectionInfoListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectionInfoListResponseBody self = new QueryCollectionInfoListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCollectionInfoListResponseBody setCollectionInfoList(java.util.List<QueryCollectionInfoListResponseBodyCollectionInfoList> collectionInfoList) {
        this.collectionInfoList = collectionInfoList;
        return this;
    }
    public java.util.List<QueryCollectionInfoListResponseBodyCollectionInfoList> getCollectionInfoList() {
        return this.collectionInfoList;
    }

    public static class QueryCollectionInfoListResponseBodyCollectionInfoList extends TeaModel {
        @NameInMap("accountHolderName")
        public String accountHolderName;

        @NameInMap("alipayLogonId")
        public String alipayLogonId;

        @NameInMap("auditStatus")
        public String auditStatus;

        @NameInMap("certNo")
        public String certNo;

        @NameInMap("collectionInfoId")
        public String collectionInfoId;

        @NameInMap("failReason")
        public String failReason;

        @NameInMap("gmtAudit")
        public Long gmtAudit;

        @NameInMap("merchantName")
        public String merchantName;

        @NameInMap("type")
        public String type;

        public static QueryCollectionInfoListResponseBodyCollectionInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryCollectionInfoListResponseBodyCollectionInfoList self = new QueryCollectionInfoListResponseBodyCollectionInfoList();
            return TeaModel.build(map, self);
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setAccountHolderName(String accountHolderName) {
            this.accountHolderName = accountHolderName;
            return this;
        }
        public String getAccountHolderName() {
            return this.accountHolderName;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setAlipayLogonId(String alipayLogonId) {
            this.alipayLogonId = alipayLogonId;
            return this;
        }
        public String getAlipayLogonId() {
            return this.alipayLogonId;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setAuditStatus(String auditStatus) {
            this.auditStatus = auditStatus;
            return this;
        }
        public String getAuditStatus() {
            return this.auditStatus;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setCertNo(String certNo) {
            this.certNo = certNo;
            return this;
        }
        public String getCertNo() {
            return this.certNo;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setCollectionInfoId(String collectionInfoId) {
            this.collectionInfoId = collectionInfoId;
            return this;
        }
        public String getCollectionInfoId() {
            return this.collectionInfoId;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setFailReason(String failReason) {
            this.failReason = failReason;
            return this;
        }
        public String getFailReason() {
            return this.failReason;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setGmtAudit(Long gmtAudit) {
            this.gmtAudit = gmtAudit;
            return this;
        }
        public Long getGmtAudit() {
            return this.gmtAudit;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setMerchantName(String merchantName) {
            this.merchantName = merchantName;
            return this;
        }
        public String getMerchantName() {
            return this.merchantName;
        }

        public QueryCollectionInfoListResponseBodyCollectionInfoList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
