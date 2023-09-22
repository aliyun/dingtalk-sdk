// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SaveClassLearningDataResponseBody extends TeaModel {
    @NameInMap("result")
    public SaveClassLearningDataResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SaveClassLearningDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveClassLearningDataResponseBody self = new SaveClassLearningDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveClassLearningDataResponseBody setResult(SaveClassLearningDataResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SaveClassLearningDataResponseBodyResult getResult() {
        return this.result;
    }

    public SaveClassLearningDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SaveClassLearningDataResponseBodyResult extends TeaModel {
        @NameInMap("questionUploadUrlList")
        public java.util.List<String> questionUploadUrlList;

        @NameInMap("standardAnswerUploadUrlList")
        public java.util.List<String> standardAnswerUploadUrlList;

        public static SaveClassLearningDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SaveClassLearningDataResponseBodyResult self = new SaveClassLearningDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SaveClassLearningDataResponseBodyResult setQuestionUploadUrlList(java.util.List<String> questionUploadUrlList) {
            this.questionUploadUrlList = questionUploadUrlList;
            return this;
        }
        public java.util.List<String> getQuestionUploadUrlList() {
            return this.questionUploadUrlList;
        }

        public SaveClassLearningDataResponseBodyResult setStandardAnswerUploadUrlList(java.util.List<String> standardAnswerUploadUrlList) {
            this.standardAnswerUploadUrlList = standardAnswerUploadUrlList;
            return this;
        }
        public java.util.List<String> getStandardAnswerUploadUrlList() {
            return this.standardAnswerUploadUrlList;
        }

    }

}
