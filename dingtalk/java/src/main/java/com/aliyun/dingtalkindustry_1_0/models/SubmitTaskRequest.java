// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("data")
    public java.util.List<SubmitTaskRequestData> data;

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

    public static class SubmitTaskRequestData extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("desc")
        public String desc;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("fileUrl")
        public java.util.List<String> fileUrl;

        @NameInMap("id")
        public Long id;

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
