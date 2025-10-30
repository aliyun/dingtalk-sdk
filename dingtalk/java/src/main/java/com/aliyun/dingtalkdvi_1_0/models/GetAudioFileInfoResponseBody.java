// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAudioFileInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetAudioFileInfoResponseBodyResult result;

    public static GetAudioFileInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAudioFileInfoResponseBody self = new GetAudioFileInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAudioFileInfoResponseBody setResult(GetAudioFileInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAudioFileInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetAudioFileInfoResponseBodyResult extends TeaModel {
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

        public static GetAudioFileInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAudioFileInfoResponseBodyResult self = new GetAudioFileInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAudioFileInfoResponseBodyResult setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetAudioFileInfoResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetAudioFileInfoResponseBodyResult setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetAudioFileInfoResponseBodyResult setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetAudioFileInfoResponseBodyResult setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetAudioFileInfoResponseBodyResult setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

    }

}
