// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryFileInfoByMinutesIdResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryFileInfoByMinutesIdResponseBodyResult result;

    public static QueryFileInfoByMinutesIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFileInfoByMinutesIdResponseBody self = new QueryFileInfoByMinutesIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFileInfoByMinutesIdResponseBody setResult(QueryFileInfoByMinutesIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryFileInfoByMinutesIdResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryFileInfoByMinutesIdResponseBodyResult extends TeaModel {
        @NameInMap("attributes")
        public java.util.Map<String, ?> attributes;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        public static QueryFileInfoByMinutesIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryFileInfoByMinutesIdResponseBodyResult self = new QueryFileInfoByMinutesIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setAttributes(java.util.Map<String, ?> attributes) {
            this.attributes = attributes;
            return this;
        }
        public java.util.Map<String, ?> getAttributes() {
            return this.attributes;
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryFileInfoByMinutesIdResponseBodyResult setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

    }

}
