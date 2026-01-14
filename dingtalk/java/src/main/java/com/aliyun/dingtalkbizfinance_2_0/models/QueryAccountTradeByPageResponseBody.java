// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAccountTradeByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("result")
    public java.util.List<QueryAccountTradeByPageResponseBodyResult> result;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryAccountTradeByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAccountTradeByPageResponseBody self = new QueryAccountTradeByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAccountTradeByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryAccountTradeByPageResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryAccountTradeByPageResponseBody setResult(java.util.List<QueryAccountTradeByPageResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryAccountTradeByPageResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryAccountTradeByPageResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryAccountTradeByPageResponseBodyResultReceiptFile extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("previewUrl")
        public String previewUrl;

        @NameInMap("spaceId")
        public String spaceId;

        public static QueryAccountTradeByPageResponseBodyResultReceiptFile build(java.util.Map<String, ?> map) throws Exception {
            QueryAccountTradeByPageResponseBodyResultReceiptFile self = new QueryAccountTradeByPageResponseBodyResultReceiptFile();
            return TeaModel.build(map, self);
        }

        public QueryAccountTradeByPageResponseBodyResultReceiptFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryAccountTradeByPageResponseBodyResultReceiptFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryAccountTradeByPageResponseBodyResultReceiptFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public QueryAccountTradeByPageResponseBodyResultReceiptFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryAccountTradeByPageResponseBodyResultReceiptFile setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

        public QueryAccountTradeByPageResponseBodyResultReceiptFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class QueryAccountTradeByPageResponseBodyResult extends TeaModel {
        @NameInMap("balance")
        public String balance;

        @NameInMap("detailId")
        public String detailId;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("instanceTitle")
        public String instanceTitle;

        @NameInMap("instanceUrl")
        public String instanceUrl;

        @NameInMap("otherAccountName")
        public String otherAccountName;

        @NameInMap("otherAccountNo")
        public String otherAccountNo;

        @NameInMap("receiptFile")
        public QueryAccountTradeByPageResponseBodyResultReceiptFile receiptFile;

        @NameInMap("remark")
        public String remark;

        @NameInMap("tradeAmount")
        public String tradeAmount;

        @NameInMap("tradeNo")
        public String tradeNo;

        @NameInMap("tradeTime")
        public Long tradeTime;

        @NameInMap("tradeType")
        public String tradeType;

        @NameInMap("usage")
        public String usage;

        public static QueryAccountTradeByPageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAccountTradeByPageResponseBodyResult self = new QueryAccountTradeByPageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAccountTradeByPageResponseBodyResult setBalance(String balance) {
            this.balance = balance;
            return this;
        }
        public String getBalance() {
            return this.balance;
        }

        public QueryAccountTradeByPageResponseBodyResult setDetailId(String detailId) {
            this.detailId = detailId;
            return this;
        }
        public String getDetailId() {
            return this.detailId;
        }

        public QueryAccountTradeByPageResponseBodyResult setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryAccountTradeByPageResponseBodyResult setInstanceTitle(String instanceTitle) {
            this.instanceTitle = instanceTitle;
            return this;
        }
        public String getInstanceTitle() {
            return this.instanceTitle;
        }

        public QueryAccountTradeByPageResponseBodyResult setInstanceUrl(String instanceUrl) {
            this.instanceUrl = instanceUrl;
            return this;
        }
        public String getInstanceUrl() {
            return this.instanceUrl;
        }

        public QueryAccountTradeByPageResponseBodyResult setOtherAccountName(String otherAccountName) {
            this.otherAccountName = otherAccountName;
            return this;
        }
        public String getOtherAccountName() {
            return this.otherAccountName;
        }

        public QueryAccountTradeByPageResponseBodyResult setOtherAccountNo(String otherAccountNo) {
            this.otherAccountNo = otherAccountNo;
            return this;
        }
        public String getOtherAccountNo() {
            return this.otherAccountNo;
        }

        public QueryAccountTradeByPageResponseBodyResult setReceiptFile(QueryAccountTradeByPageResponseBodyResultReceiptFile receiptFile) {
            this.receiptFile = receiptFile;
            return this;
        }
        public QueryAccountTradeByPageResponseBodyResultReceiptFile getReceiptFile() {
            return this.receiptFile;
        }

        public QueryAccountTradeByPageResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryAccountTradeByPageResponseBodyResult setTradeAmount(String tradeAmount) {
            this.tradeAmount = tradeAmount;
            return this;
        }
        public String getTradeAmount() {
            return this.tradeAmount;
        }

        public QueryAccountTradeByPageResponseBodyResult setTradeNo(String tradeNo) {
            this.tradeNo = tradeNo;
            return this;
        }
        public String getTradeNo() {
            return this.tradeNo;
        }

        public QueryAccountTradeByPageResponseBodyResult setTradeTime(Long tradeTime) {
            this.tradeTime = tradeTime;
            return this;
        }
        public Long getTradeTime() {
            return this.tradeTime;
        }

        public QueryAccountTradeByPageResponseBodyResult setTradeType(String tradeType) {
            this.tradeType = tradeType;
            return this;
        }
        public String getTradeType() {
            return this.tradeType;
        }

        public QueryAccountTradeByPageResponseBodyResult setUsage(String usage) {
            this.usage = usage;
            return this;
        }
        public String getUsage() {
            return this.usage;
        }

    }

}
