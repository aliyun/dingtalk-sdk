// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SyncInterviewInfoToAIInterviewAssistantRequest extends TeaModel {
    @NameInMap("candidateInfoVOList")
    public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList> candidateInfoVOList;

    @NameInMap("conferenceInfoVO")
    public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO conferenceInfoVO;

    @NameInMap("interviewEndTime")
    public Long interviewEndTime;

    @NameInMap("interviewId")
    public String interviewId;

    @NameInMap("interviewStartTime")
    public Long interviewStartTime;

    @NameInMap("interviewType")
    public String interviewType;

    @NameInMap("interviewerInfoVOList")
    public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList> interviewerInfoVOList;

    /**
     * <strong>example:</strong>
     * <p>moka</p>
     */
    @NameInMap("isvId")
    public String isvId;

    @NameInMap("jobContentVO")
    public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO jobContentVO;

    public static SyncInterviewInfoToAIInterviewAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncInterviewInfoToAIInterviewAssistantRequest self = new SyncInterviewInfoToAIInterviewAssistantRequest();
        return TeaModel.build(map, self);
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setCandidateInfoVOList(java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList> candidateInfoVOList) {
        this.candidateInfoVOList = candidateInfoVOList;
        return this;
    }
    public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList> getCandidateInfoVOList() {
        return this.candidateInfoVOList;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setConferenceInfoVO(SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO conferenceInfoVO) {
        this.conferenceInfoVO = conferenceInfoVO;
        return this;
    }
    public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO getConferenceInfoVO() {
        return this.conferenceInfoVO;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setInterviewEndTime(Long interviewEndTime) {
        this.interviewEndTime = interviewEndTime;
        return this;
    }
    public Long getInterviewEndTime() {
        return this.interviewEndTime;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setInterviewId(String interviewId) {
        this.interviewId = interviewId;
        return this;
    }
    public String getInterviewId() {
        return this.interviewId;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setInterviewStartTime(Long interviewStartTime) {
        this.interviewStartTime = interviewStartTime;
        return this;
    }
    public Long getInterviewStartTime() {
        return this.interviewStartTime;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setInterviewType(String interviewType) {
        this.interviewType = interviewType;
        return this;
    }
    public String getInterviewType() {
        return this.interviewType;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setInterviewerInfoVOList(java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList> interviewerInfoVOList) {
        this.interviewerInfoVOList = interviewerInfoVOList;
        return this;
    }
    public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList> getInterviewerInfoVOList() {
        return this.interviewerInfoVOList;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setIsvId(String isvId) {
        this.isvId = isvId;
        return this;
    }
    public String getIsvId() {
        return this.isvId;
    }

    public SyncInterviewInfoToAIInterviewAssistantRequest setJobContentVO(SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO jobContentVO) {
        this.jobContentVO = jobContentVO;
        return this;
    }
    public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO getJobContentVO() {
        return this.jobContentVO;
    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList extends TeaModel {
        @NameInMap("historyInterviewContent")
        public String historyInterviewContent;

        @NameInMap("interviewerUserId")
        public String interviewerUserId;

        public static SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList self = new SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList setHistoryInterviewContent(String historyInterviewContent) {
            this.historyInterviewContent = historyInterviewContent;
            return this;
        }
        public String getHistoryInterviewContent() {
            return this.historyInterviewContent;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList setInterviewerUserId(String interviewerUserId) {
            this.interviewerUserId = interviewerUserId;
            return this;
        }
        public String getInterviewerUserId() {
            return this.interviewerUserId;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList extends TeaModel {
        @NameInMap("aiInterviewHistoryEvaluationContentList")
        public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList> aiInterviewHistoryEvaluationContentList;

        @NameInMap("canViewUserIdList")
        public java.util.List<String> canViewUserIdList;

        @NameInMap("historyInterviewId")
        public String historyInterviewId;

        @NameInMap("historyInterviewRounds")
        public String historyInterviewRounds;

        public static SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList self = new SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList setAiInterviewHistoryEvaluationContentList(java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList> aiInterviewHistoryEvaluationContentList) {
            this.aiInterviewHistoryEvaluationContentList = aiInterviewHistoryEvaluationContentList;
            return this;
        }
        public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOListAiInterviewHistoryEvaluationContentList> getAiInterviewHistoryEvaluationContentList() {
            return this.aiInterviewHistoryEvaluationContentList;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList setCanViewUserIdList(java.util.List<String> canViewUserIdList) {
            this.canViewUserIdList = canViewUserIdList;
            return this;
        }
        public java.util.List<String> getCanViewUserIdList() {
            return this.canViewUserIdList;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList setHistoryInterviewId(String historyInterviewId) {
            this.historyInterviewId = historyInterviewId;
            return this;
        }
        public String getHistoryInterviewId() {
            return this.historyInterviewId;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList setHistoryInterviewRounds(String historyInterviewRounds) {
            this.historyInterviewRounds = historyInterviewRounds;
            return this;
        }
        public String getHistoryInterviewRounds() {
            return this.historyInterviewRounds;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList extends TeaModel {
        @NameInMap("bizCandidateId")
        public String bizCandidateId;

        @NameInMap("historyInterviewInfoVOList")
        public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList> historyInterviewInfoVOList;

        @NameInMap("name")
        public String name;

        @NameInMap("phone")
        public String phone;

        @NameInMap("resumeContent")
        public String resumeContent;

        public static SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList self = new SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList setBizCandidateId(String bizCandidateId) {
            this.bizCandidateId = bizCandidateId;
            return this;
        }
        public String getBizCandidateId() {
            return this.bizCandidateId;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList setHistoryInterviewInfoVOList(java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList> historyInterviewInfoVOList) {
            this.historyInterviewInfoVOList = historyInterviewInfoVOList;
            return this;
        }
        public java.util.List<SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOListHistoryInterviewInfoVOList> getHistoryInterviewInfoVOList() {
            return this.historyInterviewInfoVOList;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList setPhone(String phone) {
            this.phone = phone;
            return this;
        }
        public String getPhone() {
            return this.phone;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestCandidateInfoVOList setResumeContent(String resumeContent) {
            this.resumeContent = resumeContent;
            return this;
        }
        public String getResumeContent() {
            return this.resumeContent;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO self = new SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO extends TeaModel {
        @NameInMap("conferenceBookerInfoVO")
        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO conferenceBookerInfoVO;

        @NameInMap("roomCode")
        public String roomCode;

        @NameInMap("scheduleConferenceId")
        public String scheduleConferenceId;

        @NameInMap("scheduleConferenceUrl")
        public String scheduleConferenceUrl;

        public static SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO self = new SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO setConferenceBookerInfoVO(SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO conferenceBookerInfoVO) {
            this.conferenceBookerInfoVO = conferenceBookerInfoVO;
            return this;
        }
        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO getConferenceBookerInfoVO() {
            return this.conferenceBookerInfoVO;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO setRoomCode(String roomCode) {
            this.roomCode = roomCode;
            return this;
        }
        public String getRoomCode() {
            return this.roomCode;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO setScheduleConferenceId(String scheduleConferenceId) {
            this.scheduleConferenceId = scheduleConferenceId;
            return this;
        }
        public String getScheduleConferenceId() {
            return this.scheduleConferenceId;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO setScheduleConferenceUrl(String scheduleConferenceUrl) {
            this.scheduleConferenceUrl = scheduleConferenceUrl;
            return this;
        }
        public String getScheduleConferenceUrl() {
            return this.scheduleConferenceUrl;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO self = new SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("interviewEvaluationFormConfigVO")
        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO interviewEvaluationFormConfigVO;

        @NameInMap("name")
        public String name;

        @NameInMap("position")
        public String position;

        public static SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList self = new SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList setInterviewEvaluationFormConfigVO(SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO interviewEvaluationFormConfigVO) {
            this.interviewEvaluationFormConfigVO = interviewEvaluationFormConfigVO;
            return this;
        }
        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO getInterviewEvaluationFormConfigVO() {
            return this.interviewEvaluationFormConfigVO;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

    }

    public static class SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO extends TeaModel {
        @NameInMap("commitment")
        public String commitment;

        @NameInMap("hireCount")
        public Integer hireCount;

        @NameInMap("jobContent")
        public String jobContent;

        @NameInMap("jobName")
        public String jobName;

        @NameInMap("maxSalary")
        public Integer maxSalary;

        @NameInMap("minSalary")
        public Integer minSalary;

        public static SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO build(java.util.Map<String, ?> map) throws Exception {
            SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO self = new SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO();
            return TeaModel.build(map, self);
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO setCommitment(String commitment) {
            this.commitment = commitment;
            return this;
        }
        public String getCommitment() {
            return this.commitment;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO setHireCount(Integer hireCount) {
            this.hireCount = hireCount;
            return this;
        }
        public Integer getHireCount() {
            return this.hireCount;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO setJobContent(String jobContent) {
            this.jobContent = jobContent;
            return this;
        }
        public String getJobContent() {
            return this.jobContent;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO setJobName(String jobName) {
            this.jobName = jobName;
            return this;
        }
        public String getJobName() {
            return this.jobName;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO setMaxSalary(Integer maxSalary) {
            this.maxSalary = maxSalary;
            return this;
        }
        public Integer getMaxSalary() {
            return this.maxSalary;
        }

        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO setMinSalary(Integer minSalary) {
            this.minSalary = minSalary;
            return this;
        }
        public Integer getMinSalary() {
            return this.minSalary;
        }

    }

}
