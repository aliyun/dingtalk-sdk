// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SaveStudentLearningDataResponseBody extends TeaModel {
    @NameInMap("result")
    public SaveStudentLearningDataResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SaveStudentLearningDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveStudentLearningDataResponseBody self = new SaveStudentLearningDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveStudentLearningDataResponseBody setResult(SaveStudentLearningDataResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SaveStudentLearningDataResponseBodyResult getResult() {
        return this.result;
    }

    public SaveStudentLearningDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SaveStudentLearningDataResponseBodyResultWrongQuestions extends TeaModel {
        @NameInMap("questionNo")
        public String questionNo;

        @NameInMap("questionUploadUrlList")
        public java.util.List<String> questionUploadUrlList;

        @NameInMap("standardAnswerUploadUrlList")
        public java.util.List<String> standardAnswerUploadUrlList;

        @NameInMap("userAnswerUploadUrlList")
        public java.util.List<String> userAnswerUploadUrlList;

        public static SaveStudentLearningDataResponseBodyResultWrongQuestions build(java.util.Map<String, ?> map) throws Exception {
            SaveStudentLearningDataResponseBodyResultWrongQuestions self = new SaveStudentLearningDataResponseBodyResultWrongQuestions();
            return TeaModel.build(map, self);
        }

        public SaveStudentLearningDataResponseBodyResultWrongQuestions setQuestionNo(String questionNo) {
            this.questionNo = questionNo;
            return this;
        }
        public String getQuestionNo() {
            return this.questionNo;
        }

        public SaveStudentLearningDataResponseBodyResultWrongQuestions setQuestionUploadUrlList(java.util.List<String> questionUploadUrlList) {
            this.questionUploadUrlList = questionUploadUrlList;
            return this;
        }
        public java.util.List<String> getQuestionUploadUrlList() {
            return this.questionUploadUrlList;
        }

        public SaveStudentLearningDataResponseBodyResultWrongQuestions setStandardAnswerUploadUrlList(java.util.List<String> standardAnswerUploadUrlList) {
            this.standardAnswerUploadUrlList = standardAnswerUploadUrlList;
            return this;
        }
        public java.util.List<String> getStandardAnswerUploadUrlList() {
            return this.standardAnswerUploadUrlList;
        }

        public SaveStudentLearningDataResponseBodyResultWrongQuestions setUserAnswerUploadUrlList(java.util.List<String> userAnswerUploadUrlList) {
            this.userAnswerUploadUrlList = userAnswerUploadUrlList;
            return this;
        }
        public java.util.List<String> getUserAnswerUploadUrlList() {
            return this.userAnswerUploadUrlList;
        }

    }

    public static class SaveStudentLearningDataResponseBodyResult extends TeaModel {
        @NameInMap("saveSuccess")
        public Boolean saveSuccess;

        @NameInMap("wrongQuestions")
        public java.util.List<SaveStudentLearningDataResponseBodyResultWrongQuestions> wrongQuestions;

        public static SaveStudentLearningDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SaveStudentLearningDataResponseBodyResult self = new SaveStudentLearningDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SaveStudentLearningDataResponseBodyResult setSaveSuccess(Boolean saveSuccess) {
            this.saveSuccess = saveSuccess;
            return this;
        }
        public Boolean getSaveSuccess() {
            return this.saveSuccess;
        }

        public SaveStudentLearningDataResponseBodyResult setWrongQuestions(java.util.List<SaveStudentLearningDataResponseBodyResultWrongQuestions> wrongQuestions) {
            this.wrongQuestions = wrongQuestions;
            return this;
        }
        public java.util.List<SaveStudentLearningDataResponseBodyResultWrongQuestions> getWrongQuestions() {
            return this.wrongQuestions;
        }

    }

}
