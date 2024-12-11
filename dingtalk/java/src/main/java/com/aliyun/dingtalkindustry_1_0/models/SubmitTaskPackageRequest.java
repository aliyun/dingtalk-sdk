// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskPackageRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("appSecret")
    public String appSecret;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("data")
    public java.util.List<SubmitTaskPackageRequestData> data;

    @NameInMap("desc")
    public String desc;

    @NameInMap("fileType")
    public String fileType;

    @NameInMap("taskPackageName")
    public String taskPackageName;

    @NameInMap("version")
    public String version;

    public static SubmitTaskPackageRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitTaskPackageRequest self = new SubmitTaskPackageRequest();
        return TeaModel.build(map, self);
    }

    public SubmitTaskPackageRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public SubmitTaskPackageRequest setAppSecret(String appSecret) {
        this.appSecret = appSecret;
        return this;
    }
    public String getAppSecret() {
        return this.appSecret;
    }

    public SubmitTaskPackageRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public SubmitTaskPackageRequest setData(java.util.List<SubmitTaskPackageRequestData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SubmitTaskPackageRequestData> getData() {
        return this.data;
    }

    public SubmitTaskPackageRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public SubmitTaskPackageRequest setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public SubmitTaskPackageRequest setTaskPackageName(String taskPackageName) {
        this.taskPackageName = taskPackageName;
        return this;
    }
    public String getTaskPackageName() {
        return this.taskPackageName;
    }

    public SubmitTaskPackageRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public static class SubmitTaskPackageRequestData extends TeaModel {
        @NameInMap("extension")
        public String extension;

        @NameInMap("fileUrl")
        public String fileUrl;

        @NameInMap("fileUrls")
        public java.util.List<String> fileUrls;

        @NameInMap("taskName")
        public String taskName;

        @NameInMap("textContent")
        public String textContent;

        public static SubmitTaskPackageRequestData build(java.util.Map<String, ?> map) throws Exception {
            SubmitTaskPackageRequestData self = new SubmitTaskPackageRequestData();
            return TeaModel.build(map, self);
        }

        public SubmitTaskPackageRequestData setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public SubmitTaskPackageRequestData setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

        public SubmitTaskPackageRequestData setFileUrls(java.util.List<String> fileUrls) {
            this.fileUrls = fileUrls;
            return this;
        }
        public java.util.List<String> getFileUrls() {
            return this.fileUrls;
        }

        public SubmitTaskPackageRequestData setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

        public SubmitTaskPackageRequestData setTextContent(String textContent) {
            this.textContent = textContent;
            return this;
        }
        public String getTextContent() {
            return this.textContent;
        }

    }

}
