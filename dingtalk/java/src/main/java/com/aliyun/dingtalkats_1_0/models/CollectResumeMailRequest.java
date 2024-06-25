// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeMailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>liepin</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    /**
     * <strong>example:</strong>
     * <p>jobId8fc0d56a605d495ea0214af7axxxxxxx</p>
     */
    @NameInMap("deliverJobId")
    public String deliverJobId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="mailto:xxxx@163.com">xxxx@163.com</a></p>
     */
    @NameInMap("fromMailAddress")
    public String fromMailAddress;

    @NameInMap("historyMailImport")
    public Boolean historyMailImport;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxxxxxx</p>
     */
    @NameInMap("mailId")
    public String mailId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxxx应聘贵公司xxx职位</p>
     */
    @NameInMap("mailTitle")
    public String mailTitle;

    /**
     * <strong>example:</strong>
     * <p>2701606624233xxxxx</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="mailto:xxxx@163.com">xxxx@163.com</a></p>
     */
    @NameInMap("receiveMailAddress")
    public String receiveMailAddress;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiveMailType")
    public Integer receiveMailType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receivedTime")
    public Long receivedTime;

    /**
     * <strong>example:</strong>
     * <p>http:<a href="http://www.xxx.com">www.xxx.com</a></p>
     */
    @NameInMap("resumeChannelUrl")
    public String resumeChannelUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("resumeFile")
    public CollectResumeMailRequestResumeFile resumeFile;

    public static CollectResumeMailRequest build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeMailRequest self = new CollectResumeMailRequest();
        return TeaModel.build(map, self);
    }

    public CollectResumeMailRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public CollectResumeMailRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public CollectResumeMailRequest setDeliverJobId(String deliverJobId) {
        this.deliverJobId = deliverJobId;
        return this;
    }
    public String getDeliverJobId() {
        return this.deliverJobId;
    }

    public CollectResumeMailRequest setFromMailAddress(String fromMailAddress) {
        this.fromMailAddress = fromMailAddress;
        return this;
    }
    public String getFromMailAddress() {
        return this.fromMailAddress;
    }

    public CollectResumeMailRequest setHistoryMailImport(Boolean historyMailImport) {
        this.historyMailImport = historyMailImport;
        return this;
    }
    public Boolean getHistoryMailImport() {
        return this.historyMailImport;
    }

    public CollectResumeMailRequest setMailId(String mailId) {
        this.mailId = mailId;
        return this;
    }
    public String getMailId() {
        return this.mailId;
    }

    public CollectResumeMailRequest setMailTitle(String mailTitle) {
        this.mailTitle = mailTitle;
        return this;
    }
    public String getMailTitle() {
        return this.mailTitle;
    }

    public CollectResumeMailRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public CollectResumeMailRequest setReceiveMailAddress(String receiveMailAddress) {
        this.receiveMailAddress = receiveMailAddress;
        return this;
    }
    public String getReceiveMailAddress() {
        return this.receiveMailAddress;
    }

    public CollectResumeMailRequest setReceiveMailType(Integer receiveMailType) {
        this.receiveMailType = receiveMailType;
        return this;
    }
    public Integer getReceiveMailType() {
        return this.receiveMailType;
    }

    public CollectResumeMailRequest setReceivedTime(Long receivedTime) {
        this.receivedTime = receivedTime;
        return this;
    }
    public Long getReceivedTime() {
        return this.receivedTime;
    }

    public CollectResumeMailRequest setResumeChannelUrl(String resumeChannelUrl) {
        this.resumeChannelUrl = resumeChannelUrl;
        return this;
    }
    public String getResumeChannelUrl() {
        return this.resumeChannelUrl;
    }

    public CollectResumeMailRequest setResumeFile(CollectResumeMailRequestResumeFile resumeFile) {
        this.resumeFile = resumeFile;
        return this;
    }
    public CollectResumeMailRequestResumeFile getResumeFile() {
        return this.resumeFile;
    }

    public static class CollectResumeMailRequestResumeFile extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>http:<a href="http://www.xxx.com">www.xxx.com</a></p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxx的简历.pdf</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>pdf</p>
         */
        @NameInMap("fileType")
        public String fileType;

        public static CollectResumeMailRequestResumeFile build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeMailRequestResumeFile self = new CollectResumeMailRequestResumeFile();
            return TeaModel.build(map, self);
        }

        public CollectResumeMailRequestResumeFile setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public CollectResumeMailRequestResumeFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CollectResumeMailRequestResumeFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

    }

}
