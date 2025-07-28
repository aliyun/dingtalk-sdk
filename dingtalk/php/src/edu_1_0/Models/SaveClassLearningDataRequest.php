<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveClassLearningDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $assignNum;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $assignStudentUserIds;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example HOMEWORK
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxxxxxxxxxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
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
     * @description This parameter is required.
     *
     * @example 1672502400000
     *
     * @var int
     */
    public $generatedTime;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $questionNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $questionPictureNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $standardAnswerPictureNum;

    /**
     * @description This parameter is required.
     *
     * @example shuxue
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @description This parameter is required.
     *
     * @example 0123456
     *
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'assignNum' => 'assignNum',
        'assignStudentUserIds' => 'assignStudentUserIds',
        'bizId' => 'bizId',
        'bizType' => 'bizType',
        'corpId' => 'corpId',
        'deptId' => 'deptId',
        'fileSuffix' => 'fileSuffix',
        'generatedTime' => 'generatedTime',
        'questionNum' => 'questionNum',
        'questionPictureNum' => 'questionPictureNum',
        'standardAnswerPictureNum' => 'standardAnswerPictureNum',
        'subjectCode' => 'subjectCode',
        'teacherUserId' => 'teacherUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assignNum) {
            $res['assignNum'] = $this->assignNum;
        }
        if (null !== $this->assignStudentUserIds) {
            $res['assignStudentUserIds'] = $this->assignStudentUserIds;
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
        if (null !== $this->questionPictureNum) {
            $res['questionPictureNum'] = $this->questionPictureNum;
        }
        if (null !== $this->standardAnswerPictureNum) {
            $res['standardAnswerPictureNum'] = $this->standardAnswerPictureNum;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveClassLearningDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assignNum'])) {
            $model->assignNum = $map['assignNum'];
        }
        if (isset($map['assignStudentUserIds'])) {
            if (!empty($map['assignStudentUserIds'])) {
                $model->assignStudentUserIds = $map['assignStudentUserIds'];
            }
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
        if (isset($map['questionPictureNum'])) {
            $model->questionPictureNum = $map['questionPictureNum'];
        }
        if (isset($map['standardAnswerPictureNum'])) {
            $model->standardAnswerPictureNum = $map['standardAnswerPictureNum'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
