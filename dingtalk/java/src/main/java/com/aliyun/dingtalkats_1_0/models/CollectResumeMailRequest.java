// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeMailRequest extends TeaModel {
    /**
     * <p>业务标识</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>渠道编码</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    /**
     * <p>候选人投递职位标识</p>
     */
    @NameInMap("deliverJobId")
    public String deliverJobId;

    /**
     * <p>邮件来源地址</p>
     */
    @NameInMap("fromMailAddress")
    public String fromMailAddress;

    /**
     * <p>邮件唯一标识</p>
     */
    @NameInMap("mailId")
    public String mailId;

    /**
     * <p>邮件标题</p>
     */
    @NameInMap("mailTitle")
    public String mailTitle;

    /**
     * <p>操作人userId</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <p>收件邮箱地址</p>
     */
    @NameInMap("receiveMailAddress")
    public String receiveMailAddress;

    /**
     * <p>收件邮箱类型</p>
     */
    @NameInMap("receiveMailType")
    public Integer receiveMailType;

    /**
     * <p>收件时间</p>
     */
    @NameInMap("receivedTime")
    public Long receivedTime;

    /**
     * <p>渠道简历跳转链接</p>
     */
    @NameInMap("resumeChannelUrl")
    public String resumeChannelUrl;

    /**
     * <p>简历原始文件</p>
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
         * <p>文件下载地址</p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        /**
         * <p>文件名称</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件类型</p>
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
