// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardFinishProgressResponseBody extends TeaModel {
    @NameInMap("result")
    public CardGetCardFinishProgressResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CardGetCardFinishProgressResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CardGetCardFinishProgressResponseBody self = new CardGetCardFinishProgressResponseBody();
        return TeaModel.build(map, self);
    }

    public CardGetCardFinishProgressResponseBody setResult(CardGetCardFinishProgressResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CardGetCardFinishProgressResponseBodyResult getResult() {
        return this.result;
    }

    public CardGetCardFinishProgressResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2023-11-01</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>11</p>
         */
        @NameInMap("finishedStudentsNum")
        public Long finishedStudentsNum;

        /**
         * <strong>example:</strong>
         * <p>11</p>
         */
        @NameInMap("needFinishStudentsNum")
        public Long needFinishStudentsNum;

        /**
         * <strong>example:</strong>
         * <p>CARD_TASK_CODE_0</p>
         */
        @NameInMap("taskCode")
        public String taskCode;

        /**
         * <strong>example:</strong>
         * <p>2023-11-01</p>
         */
        @NameInMap("today")
        public String today;

        public static CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess build(java.util.Map<String, ?> map) throws Exception {
            CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess self = new CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess();
            return TeaModel.build(map, self);
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess setFinishedStudentsNum(Long finishedStudentsNum) {
            this.finishedStudentsNum = finishedStudentsNum;
            return this;
        }
        public Long getFinishedStudentsNum() {
            return this.finishedStudentsNum;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess setNeedFinishStudentsNum(Long needFinishStudentsNum) {
            this.needFinishStudentsNum = needFinishStudentsNum;
            return this;
        }
        public Long getNeedFinishStudentsNum() {
            return this.needFinishStudentsNum;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess setTaskCode(String taskCode) {
            this.taskCode = taskCode;
            return this;
        }
        public String getTaskCode() {
            return this.taskCode;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess setToday(String today) {
            this.today = today;
            return this;
        }
        public String getToday() {
            return this.today;
        }

    }

    public static class CardGetCardFinishProgressResponseBodyResultClassStatistics extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <strong>example:</strong>
         * <p>二年级1班</p>
         */
        @NameInMap("cardBizName")
        public String cardBizName;

        /**
         * <strong>example:</strong>
         * <p>3424234</p>
         */
        @NameInMap("classId")
        public String classId;

        /**
         * <strong>example:</strong>
         * <p>二年级1班</p>
         */
        @NameInMap("className")
        public String className;

        @NameInMap("process")
        public java.util.List<CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess> process;

        public static CardGetCardFinishProgressResponseBodyResultClassStatistics build(java.util.Map<String, ?> map) throws Exception {
            CardGetCardFinishProgressResponseBodyResultClassStatistics self = new CardGetCardFinishProgressResponseBodyResultClassStatistics();
            return TeaModel.build(map, self);
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatistics setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatistics setCardBizName(String cardBizName) {
            this.cardBizName = cardBizName;
            return this;
        }
        public String getCardBizName() {
            return this.cardBizName;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatistics setClassId(String classId) {
            this.classId = classId;
            return this;
        }
        public String getClassId() {
            return this.classId;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatistics setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public CardGetCardFinishProgressResponseBodyResultClassStatistics setProcess(java.util.List<CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess> process) {
            this.process = process;
            return this;
        }
        public java.util.List<CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess> getProcess() {
            return this.process;
        }

    }

    public static class CardGetCardFinishProgressResponseBodyResultPatriarchStatistics extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>CARD_TASK_CODE_0</p>
         */
        @NameInMap("cardTaskCode")
        public String cardTaskCode;

        /**
         * <strong>example:</strong>
         * <p>2023-11-01</p>
         */
        @NameInMap("date")
        public String date;

        @NameInMap("isFinished")
        public Boolean isFinished;

        @NameInMap("isFinishedByReissueCard")
        public Boolean isFinishedByReissueCard;

        @NameInMap("isLastDay")
        public Boolean isLastDay;

        @NameInMap("reissueCard")
        public Boolean reissueCard;

        /**
         * <strong>example:</strong>
         * <p>23424234</p>
         */
        @NameInMap("studentId")
        public String studentId;

        /**
         * <strong>example:</strong>
         * <p>李四</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <strong>example:</strong>
         * <p>2023-11-01</p>
         */
        @NameInMap("today")
        public String today;

        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("userSubTaskId")
        public Long userSubTaskId;

        public static CardGetCardFinishProgressResponseBodyResultPatriarchStatistics build(java.util.Map<String, ?> map) throws Exception {
            CardGetCardFinishProgressResponseBodyResultPatriarchStatistics self = new CardGetCardFinishProgressResponseBodyResultPatriarchStatistics();
            return TeaModel.build(map, self);
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setCardTaskCode(String cardTaskCode) {
            this.cardTaskCode = cardTaskCode;
            return this;
        }
        public String getCardTaskCode() {
            return this.cardTaskCode;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setIsFinished(Boolean isFinished) {
            this.isFinished = isFinished;
            return this;
        }
        public Boolean getIsFinished() {
            return this.isFinished;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setIsFinishedByReissueCard(Boolean isFinishedByReissueCard) {
            this.isFinishedByReissueCard = isFinishedByReissueCard;
            return this;
        }
        public Boolean getIsFinishedByReissueCard() {
            return this.isFinishedByReissueCard;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setIsLastDay(Boolean isLastDay) {
            this.isLastDay = isLastDay;
            return this;
        }
        public Boolean getIsLastDay() {
            return this.isLastDay;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setReissueCard(Boolean reissueCard) {
            this.reissueCard = reissueCard;
            return this;
        }
        public Boolean getReissueCard() {
            return this.reissueCard;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setStudentId(String studentId) {
            this.studentId = studentId;
            return this;
        }
        public String getStudentId() {
            return this.studentId;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setToday(String today) {
            this.today = today;
            return this;
        }
        public String getToday() {
            return this.today;
        }

        public CardGetCardFinishProgressResponseBodyResultPatriarchStatistics setUserSubTaskId(Long userSubTaskId) {
            this.userSubTaskId = userSubTaskId;
            return this;
        }
        public Long getUserSubTaskId() {
            return this.userSubTaskId;
        }

    }

    public static class CardGetCardFinishProgressResponseBodyResult extends TeaModel {
        @NameInMap("classStatistics")
        public java.util.List<CardGetCardFinishProgressResponseBodyResultClassStatistics> classStatistics;

        @NameInMap("patriarchStatistics")
        public java.util.List<CardGetCardFinishProgressResponseBodyResultPatriarchStatistics> patriarchStatistics;

        @NameInMap("studentNameList")
        public java.util.List<String> studentNameList;

        public static CardGetCardFinishProgressResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CardGetCardFinishProgressResponseBodyResult self = new CardGetCardFinishProgressResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CardGetCardFinishProgressResponseBodyResult setClassStatistics(java.util.List<CardGetCardFinishProgressResponseBodyResultClassStatistics> classStatistics) {
            this.classStatistics = classStatistics;
            return this;
        }
        public java.util.List<CardGetCardFinishProgressResponseBodyResultClassStatistics> getClassStatistics() {
            return this.classStatistics;
        }

        public CardGetCardFinishProgressResponseBodyResult setPatriarchStatistics(java.util.List<CardGetCardFinishProgressResponseBodyResultPatriarchStatistics> patriarchStatistics) {
            this.patriarchStatistics = patriarchStatistics;
            return this;
        }
        public java.util.List<CardGetCardFinishProgressResponseBodyResultPatriarchStatistics> getPatriarchStatistics() {
            return this.patriarchStatistics;
        }

        public CardGetCardFinishProgressResponseBodyResult setStudentNameList(java.util.List<String> studentNameList) {
            this.studentNameList = studentNameList;
            return this;
        }
        public java.util.List<String> getStudentNameList() {
            return this.studentNameList;
        }

    }

}
