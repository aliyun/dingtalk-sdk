<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $activeTimeGMT;

    /**
     * @var string
     */
    public $activityId;

    /**
     * @var string
     */
    public $actualActionerId;

    /**
     * @var string
     */
    public $createTimeGMT;

    /**
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @var string
     */
    public $originatorId;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $taskId;

    /**
     * @var string
     */
    public $taskType;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $titleInEnglish;
    protected $_name = [
        'activeTimeGMT'     => 'activeTimeGMT',
        'activityId'        => 'activityId',
        'actualActionerId'  => 'actualActionerId',
        'createTimeGMT'     => 'createTimeGMT',
        'finishTimeGMT'     => 'finishTimeGMT',
        'originatorId'      => 'originatorId',
        'processInstanceId' => 'processInstanceId',
        'status'            => 'status',
        'taskId'            => 'taskId',
        'taskType'          => 'taskType',
        'title'             => 'title',
        'titleInEnglish'    => 'titleInEnglish',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeTimeGMT) {
            $res['activeTimeGMT'] = $this->activeTimeGMT;
        }
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->actualActionerId) {
            $res['actualActionerId'] = $this->actualActionerId;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->titleInEnglish) {
            $res['titleInEnglish'] = $this->titleInEnglish;
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
        if (isset($map['activeTimeGMT'])) {
            $model->activeTimeGMT = $map['activeTimeGMT'];
        }
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['actualActionerId'])) {
            $model->actualActionerId = $map['actualActionerId'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['titleInEnglish'])) {
            $model->titleInEnglish = $map['titleInEnglish'];
        }

        return $model;
    }
}
