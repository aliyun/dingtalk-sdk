// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitAsrTaskRequest extends TeaModel {
    @NameInMap("bizKey")
    public String bizKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    @NameInMap("phrases")
    public java.util.List<String> phrases;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceLanguage")
    public String sourceLanguage;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    @NameInMap("transcription")
    public SubmitAsrTaskRequestTranscription transcription;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SubmitAsrTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitAsrTaskRequest self = new SubmitAsrTaskRequest();
        return TeaModel.build(map, self);
    }

    public SubmitAsrTaskRequest setBizKey(String bizKey) {
        this.bizKey = bizKey;
        return this;
    }
    public String getBizKey() {
        return this.bizKey;
    }

    public SubmitAsrTaskRequest setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public SubmitAsrTaskRequest setPhrases(java.util.List<String> phrases) {
        this.phrases = phrases;
        return this;
    }
    public java.util.List<String> getPhrases() {
        return this.phrases;
    }

    public SubmitAsrTaskRequest setSourceLanguage(String sourceLanguage) {
        this.sourceLanguage = sourceLanguage;
        return this;
    }
    public String getSourceLanguage() {
        return this.sourceLanguage;
    }

    public SubmitAsrTaskRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public SubmitAsrTaskRequest setTranscription(SubmitAsrTaskRequestTranscription transcription) {
        this.transcription = transcription;
        return this;
    }
    public SubmitAsrTaskRequestTranscription getTranscription() {
        return this.transcription;
    }

    public SubmitAsrTaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class SubmitAsrTaskRequestTranscriptionDiarization extends TeaModel {
        @NameInMap("speakerCount")
        public Long speakerCount;

        public static SubmitAsrTaskRequestTranscriptionDiarization build(java.util.Map<String, ?> map) throws Exception {
            SubmitAsrTaskRequestTranscriptionDiarization self = new SubmitAsrTaskRequestTranscriptionDiarization();
            return TeaModel.build(map, self);
        }

        public SubmitAsrTaskRequestTranscriptionDiarization setSpeakerCount(Long speakerCount) {
            this.speakerCount = speakerCount;
            return this;
        }
        public Long getSpeakerCount() {
            return this.speakerCount;
        }

    }

    public static class SubmitAsrTaskRequestTranscription extends TeaModel {
        @NameInMap("diarization")
        public SubmitAsrTaskRequestTranscriptionDiarization diarization;

        @NameInMap("diarizationEnabled")
        public Boolean diarizationEnabled;

        public static SubmitAsrTaskRequestTranscription build(java.util.Map<String, ?> map) throws Exception {
            SubmitAsrTaskRequestTranscription self = new SubmitAsrTaskRequestTranscription();
            return TeaModel.build(map, self);
        }

        public SubmitAsrTaskRequestTranscription setDiarization(SubmitAsrTaskRequestTranscriptionDiarization diarization) {
            this.diarization = diarization;
            return this;
        }
        public SubmitAsrTaskRequestTranscriptionDiarization getDiarization() {
            return this.diarization;
        }

        public SubmitAsrTaskRequestTranscription setDiarizationEnabled(Boolean diarizationEnabled) {
            this.diarizationEnabled = diarizationEnabled;
            return this;
        }
        public Boolean getDiarizationEnabled() {
            return this.diarizationEnabled;
        }

    }

}
