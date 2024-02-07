<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataRequest\wrongQuestions;
use AlibabaCloud\Tea\Model;

class SaveStudentLearningDataRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $assignNum;

    /**
     * @example 1
     *
     * @var string
     */
    public $bizId;

    /**
     * @example HOMEWORK
     *
     * @var string
     */
    public $bizType;

    /**
     * @example dingxxxxxxxxxxxxxxxxxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1
     *
     * @var int
     */
    public $correctNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $deptId;

    /**
     * @example .jpeg
     *
     * @var string
     */
    public $fileSuffix;

    /**
     * @example 1672502400000
     *
     * @var int
     */
    public $generatedTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $questionNum;

    /**
     * @example 0123456
     *
     * @var string
     */
    public $studentUserId;

    /**
     * @example shuxue
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @example 1
     *
     * @var int
     */
    public $submitNum;

    /**
     * @var wrongQuestions[]
     */
    public $wrongQuestions;
    protected $_name = [
        'assignNum'      => 'assignNum',
        'bizId'          => 'bizId',
        'bizType'        => 'bizType',
        'corpId'         => 'corpId',
        'correctNum'     => 'correctNum',
        'deptId'         => 'deptId',
        'fileSuffix'     => 'fileSuffix',
        'generatedTime'  => 'generatedTime',
        'questionNum'    => 'questionNum',
        'studentUserId'  => 'studentUserId',
        'subjectCode'    => 'subjectCode',
        'submitNum'      => 'submitNum',
        'wrongQuestions' => 'wrongQuestions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assignNum) {
            $res['assignNum'] = $this->assignNum;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->correctNum) {
            $res['correctNum'] = $this->correctNum;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->fileSuffix) {
            $res['fileSuffix'] = $this->fileSuffix;
        }
        if (null !== $this->generatedTime) {
            $res['generatedTime'] = $this->generatedTime;
        }
        if (null !== $this->questionNum) {
            $res['questionNum'] = $this->questionNum;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->submitNum) {
            $res['submitNum'] = $this->submitNum;
        }
        if (null !== $this->wrongQuestions) {
            $res['wrongQuestions'] = [];
            if (null !== $this->wrongQuestions && \is_array($this->wrongQuestions)) {
                $n = 0;
                foreach ($this->wrongQuestions as $item) {
                    $res['wrongQuestions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveStudentLearningDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assignNum'])) {
            $model->assignNum = $map['assignNum'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['correctNum'])) {
            $model->correctNum = $map['correctNum'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['fileSuffix'])) {
            $model->fileSuffix = $map['fileSuffix'];
        }
        if (isset($map['generatedTime'])) {
            $model->generatedTime = $map['generatedTime'];
        }
        if (isset($map['questionNum'])) {
            $model->questionNum = $map['questionNum'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['submitNum'])) {
            $model->submitNum = $map['submitNum'];
        }
        if (isset($map['wrongQuestions'])) {
            if (!empty($map['wrongQuestions'])) {
                $model->wrongQuestions = [];
                $n                     = 0;
                foreach ($map['wrongQuestions'] as $item) {
                    $model->wrongQuestions[$n++] = null !== $item ? wrongQuestions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
