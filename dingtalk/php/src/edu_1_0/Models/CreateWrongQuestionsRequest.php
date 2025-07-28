<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWrongQuestionsRequest extends Model
{
    /**
     * @var string
     */
    public $answerContent;

    /**
     * @var int
     */
    public $difficultyLevel;

    /**
     * @var string
     */
    public $explainAudio;

    /**
     * @var string
     */
    public $explainContent;

    /**
     * @var int
     */
    public $generateTime;

    /**
     * @var string[]
     */
    public $knowledgePointList;

    /**
     * @var string
     */
    public $ownerCode;

    /**
     * @var string
     */
    public $ownerType;

    /**
     * @var int
     */
    public $proficiencyLevel;

    /**
     * @var string
     */
    public $questionAudio;

    /**
     * @var string
     */
    public $questionContent;

    /**
     * @var string[]
     */
    public $questionExtension;

    /**
     * @var string
     */
    public $questionPicUrl;

    /**
     * @var string
     */
    public $questionType;

    /**
     * @var string
     */
    public $sourceCode;

    /**
     * @var string
     */
    public $studentUserId;

    /**
     * @var string
     */
    public $subject;
    protected $_name = [
        'answerContent' => 'answerContent',
        'difficultyLevel' => 'difficultyLevel',
        'explainAudio' => 'explainAudio',
        'explainContent' => 'explainContent',
        'generateTime' => 'generateTime',
        'knowledgePointList' => 'knowledgePointList',
        'ownerCode' => 'ownerCode',
        'ownerType' => 'ownerType',
        'proficiencyLevel' => 'proficiencyLevel',
        'questionAudio' => 'questionAudio',
        'questionContent' => 'questionContent',
        'questionExtension' => 'questionExtension',
        'questionPicUrl' => 'questionPicUrl',
        'questionType' => 'questionType',
        'sourceCode' => 'sourceCode',
        'studentUserId' => 'studentUserId',
        'subject' => 'subject',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->answerContent) {
            $res['answerContent'] = $this->answerContent;
        }
        if (null !== $this->difficultyLevel) {
            $res['difficultyLevel'] = $this->difficultyLevel;
        }
        if (null !== $this->explainAudio) {
            $res['explainAudio'] = $this->explainAudio;
        }
        if (null !== $this->explainContent) {
            $res['explainContent'] = $this->explainContent;
        }
        if (null !== $this->generateTime) {
            $res['generateTime'] = $this->generateTime;
        }
        if (null !== $this->knowledgePointList) {
            $res['knowledgePointList'] = $this->knowledgePointList;
        }
        if (null !== $this->ownerCode) {
            $res['ownerCode'] = $this->ownerCode;
        }
        if (null !== $this->ownerType) {
            $res['ownerType'] = $this->ownerType;
        }
        if (null !== $this->proficiencyLevel) {
            $res['proficiencyLevel'] = $this->proficiencyLevel;
        }
        if (null !== $this->questionAudio) {
            $res['questionAudio'] = $this->questionAudio;
        }
        if (null !== $this->questionContent) {
            $res['questionContent'] = $this->questionContent;
        }
        if (null !== $this->questionExtension) {
            $res['questionExtension'] = $this->questionExtension;
        }
        if (null !== $this->questionPicUrl) {
            $res['questionPicUrl'] = $this->questionPicUrl;
        }
        if (null !== $this->questionType) {
            $res['questionType'] = $this->questionType;
        }
        if (null !== $this->sourceCode) {
            $res['sourceCode'] = $this->sourceCode;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWrongQuestionsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['answerContent'])) {
            $model->answerContent = $map['answerContent'];
        }
        if (isset($map['difficultyLevel'])) {
            $model->difficultyLevel = $map['difficultyLevel'];
        }
        if (isset($map['explainAudio'])) {
            $model->explainAudio = $map['explainAudio'];
        }
        if (isset($map['explainContent'])) {
            $model->explainContent = $map['explainContent'];
        }
        if (isset($map['generateTime'])) {
            $model->generateTime = $map['generateTime'];
        }
        if (isset($map['knowledgePointList'])) {
            if (!empty($map['knowledgePointList'])) {
                $model->knowledgePointList = $map['knowledgePointList'];
            }
        }
        if (isset($map['ownerCode'])) {
            $model->ownerCode = $map['ownerCode'];
        }
        if (isset($map['ownerType'])) {
            $model->ownerType = $map['ownerType'];
        }
        if (isset($map['proficiencyLevel'])) {
            $model->proficiencyLevel = $map['proficiencyLevel'];
        }
        if (isset($map['questionAudio'])) {
            $model->questionAudio = $map['questionAudio'];
        }
        if (isset($map['questionContent'])) {
            $model->questionContent = $map['questionContent'];
        }
        if (isset($map['questionExtension'])) {
            $model->questionExtension = $map['questionExtension'];
        }
        if (isset($map['questionPicUrl'])) {
            $model->questionPicUrl = $map['questionPicUrl'];
        }
        if (isset($map['questionType'])) {
            $model->questionType = $map['questionType'];
        }
        if (isset($map['sourceCode'])) {
            $model->sourceCode = $map['sourceCode'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }

        return $model;
    }
}
