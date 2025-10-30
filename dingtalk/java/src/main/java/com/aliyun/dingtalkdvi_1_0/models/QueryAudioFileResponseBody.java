// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryAudioFileResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<QueryAudioFileResponseBodyResult> result;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryAudioFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAudioFileResponseBody self = new QueryAudioFileResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAudioFileResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAudioFileResponseBody setResult(java.util.List<QueryAudioFileResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryAudioFileResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryAudioFileResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryAudioFileResponseBodyResult extends TeaModel {
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

        public static QueryAudioFileResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAudioFileResponseBodyResult self = new QueryAudioFileResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAudioFileResponseBodyResult setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryAudioFileResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryAudioFileResponseBodyResult setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryAudioFileResponseBodyResult setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryAudioFileResponseBodyResult setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryAudioFileResponseBodyResult setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

    }

}
