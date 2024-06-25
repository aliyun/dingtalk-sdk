// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SyncReceiptRecallRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>https:xxxx.pdf</p>
     */
    @NameInMap("fileDownloadUrl")
    public String fileDownloadUrl;

    /**
     * <strong>example:</strong>
     * <p>1234.pdf</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    public static SyncReceiptRecallRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncReceiptRecallRequest self = new SyncReceiptRecallRequest();
        return TeaModel.build(map, self);
    }

    public SyncReceiptRecallRequest setFileDownloadUrl(String fileDownloadUrl) {
        this.fileDownloadUrl = fileDownloadUrl;
        return this;
    }
    public String getFileDownloadUrl() {
        return this.fileDownloadUrl;
    }

    public SyncReceiptRecallRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public SyncReceiptRecallRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

}
