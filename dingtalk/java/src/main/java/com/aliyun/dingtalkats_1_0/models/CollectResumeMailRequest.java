// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeMailRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("channelCode")
    public String channelCode;

    @NameInMap("deliverJobId")
    public String deliverJobId;

    @NameInMap("fromMailAddress")
    public String fromMailAddress;

    @NameInMap("mailId")
    public String mailId;

    @NameInMap("mailTitle")
    public String mailTitle;

    @NameInMap("optUserId")
    public String optUserId;

    @NameInMap("receiveMailAddress")
    public String receiveMailAddress;

    @NameInMap("receiveMailType")
    public Integer receiveMailType;

    @NameInMap("receivedTime")
    public Long receivedTime;

    @NameInMap("resumeChannelUrl")
    public String resumeChannelUrl;

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
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fileName")
        public String fileName;

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
