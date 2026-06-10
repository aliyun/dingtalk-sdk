<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgCorrectTaskDetailResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $aiMarkId;

    /**
     * @var int
     */
    public $aiMarkTime;

    /**
     * @var string
     */
    public $aiModel;

    /**
     * @var string
     */
    public $className;

    /**
     * @var int
     */
    public $gradeLevel;

    /**
     * @var string
     */
    public $gradeName;

    /**
     * @var string
     */
    public $periodCode;

    /**
     * @var string
     */
    public $scanDeviceId;

    /**
     * @var int
     */
    public $scanTime;

    /**
     * @var string
     */
    public $schoolName;

    /**
     * @var float
     */
    public $score;

    /**
     * @var string
     */
    public $studentName;

    /**
     * @var string
     */
    public $taskCode;

    /**
     * @var string
     */
    public $taskName;

    /**
     * @var string
     */
    public $teacherName;

    /**
     * @var float
     */
    public $totalScore;
    protected $_name = [
        'aiMarkId' => 'aiMarkId',
        'aiMarkTime' => 'aiMarkTime',
        'aiModel' => 'aiModel',
        'className' => 'className',
        'gradeLevel' => 'gradeLevel',
        'gradeName' => 'gradeName',
        'periodCode' => 'periodCode',
        'scanDeviceId' => 'scanDeviceId',
        'scanTime' => 'scanTime',
        'schoolName' => 'schoolName',
        'score' => 'score',
        'studentName' => 'studentName',
        'taskCode' => 'taskCode',
        'taskName' => 'taskName',
        'teacherName' => 'teacherName',
        'totalScore' => 'totalScore',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiMarkId) {
            $res['aiMarkId'] = $this->aiMarkId;
        }
        if (null !== $this->aiMarkTime) {
            $res['aiMarkTime'] = $this->aiMarkTime;
        }
        if (null !== $this->aiModel) {
            $res['aiModel'] = $this->aiModel;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->gradeLevel) {
            $res['gradeLevel'] = $this->gradeLevel;
        }
        if (null !== $this->gradeName) {
            $res['gradeName'] = $this->gradeName;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->scanDeviceId) {
            $res['scanDeviceId'] = $this->scanDeviceId;
        }
        if (null !== $this->scanTime) {
            $res['scanTime'] = $this->scanTime;
        }
        if (null !== $this->schoolName) {
            $res['schoolName'] = $this->schoolName;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->totalScore) {
            $res['totalScore'] = $this->totalScore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiMarkId'])) {
            $model->aiMarkId = $map['aiMarkId'];
        }
        if (isset($map['aiMarkTime'])) {
            $model->aiMarkTime = $map['aiMarkTime'];
        }
        if (isset($map['aiModel'])) {
            $model->aiModel = $map['aiModel'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['gradeLevel'])) {
            $model->gradeLevel = $map['gradeLevel'];
        }
        if (isset($map['gradeName'])) {
            $model->gradeName = $map['gradeName'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['scanDeviceId'])) {
            $model->scanDeviceId = $map['scanDeviceId'];
        }
        if (isset($map['scanTime'])) {
            $model->scanTime = $map['scanTime'];
        }
        if (isset($map['schoolName'])) {
            $model->schoolName = $map['schoolName'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['totalScore'])) {
            $model->totalScore = $map['totalScore'];
        }

        return $model;
    }
}
