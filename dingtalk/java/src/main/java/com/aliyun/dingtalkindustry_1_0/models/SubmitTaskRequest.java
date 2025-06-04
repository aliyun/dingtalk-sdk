// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("appId")
    public Long appId;

    /**
     * <strong>example:</strong>
     * <p>MEETING</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("data")
    public java.util.List<SubmitTaskRequestData> data;

    @NameInMap("unionId")
    public String unionId;

    public static SubmitTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitTaskRequest self = new SubmitTaskRequest();
        return TeaModel.build(map, self);
    }

    public SubmitTaskRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public SubmitTaskRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public SubmitTaskRequest setData(java.util.List<SubmitTaskRequestData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SubmitTaskRequestData> getData() {
        return this.data;
    }

    public SubmitTaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class SubmitTaskRequestData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2024-05-14</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>xx项目</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>根据不同业务类型，传业务需求的JSON字符串</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <strong>example:</strong>
         * <p>audio</p>
         */
        @NameInMap("fileType")
        public String fileType;

        @NameInMap("fileUrl")
        public java.util.List<String> fileUrl;

        /**
         * <strong>example:</strong>
         * <p>1001</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>xx项目会议</p>
         */
        @NameInMap("name")
        public String name;

        public static SubmitTaskRequestData build(java.util.Map<String, ?> map) throws Exception {
            SubmitTaskRequestData self = new SubmitTaskRequestData();
            return TeaModel.build(map, self);
        }

        public SubmitTaskRequestData setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public SubmitTaskRequestData setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public SubmitTaskRequestData setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public SubmitTaskRequestData setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public SubmitTaskRequestData setFileUrl(java.util.List<String> fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public java.util.List<String> getFileUrl() {
            return this.fileUrl;
        }

        public SubmitTaskRequestData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SubmitTaskRequestData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
