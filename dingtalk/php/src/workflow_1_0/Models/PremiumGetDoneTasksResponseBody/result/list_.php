<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetDoneTasksResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $activityId;

    /**
     * @var string
     */
    public $formMassage;

    /**
     * @var string
     */
    public $originatorId;

    /**
     * @var string
     */
    public $originatorName;

    /**
     * @var string
     */
    public $originatorPhoto;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @var string
     */
    public $processCreateTime;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @var string
     */
    public $processEndTime;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var int
     */
    public $processType;

    /**
     * @example agree
     *
     * @var string
     */
    public $result;

    /**
     * @example RUNNING
     *
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
    public $title;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'activityId'        => 'activityId',
        'formMassage'       => 'formMassage',
        'originatorId'      => 'originatorId',
        'originatorName'    => 'originatorName',
        'originatorPhoto'   => 'originatorPhoto',
        'processCreateTime' => 'processCreateTime',
        'processEndTime'    => 'processEndTime',
        'processInstanceId' => 'processInstanceId',
        'processType'       => 'processType',
        'result'            => 'result',
        'status'            => 'status',
        'taskId'            => 'taskId',
        'title'             => 'title',
        'url'               => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->formMassage) {
            $res['formMassage'] = $this->formMassage;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->originatorName) {
            $res['originatorName'] = $this->originatorName;
        }
        if (null !== $this->originatorPhoto) {
            $res['originatorPhoto'] = $this->originatorPhoto;
        }
        if (null !== $this->processCreateTime) {
            $res['processCreateTime'] = $this->processCreateTime;
        }
        if (null !== $this->processEndTime) {
            $res['processEndTime'] = $this->processEndTime;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->processType) {
            $res['processType'] = $this->processType;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['formMassage'])) {
            $model->formMassage = $map['formMassage'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['originatorName'])) {
            $model->originatorName = $map['originatorName'];
        }
        if (isset($map['originatorPhoto'])) {
            $model->originatorPhoto = $map['originatorPhoto'];
        }
        if (isset($map['processCreateTime'])) {
            $model->processCreateTime = $map['processCreateTime'];
        }
        if (isset($map['processEndTime'])) {
            $model->processEndTime = $map['processEndTime'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['processType'])) {
            $model->processType = $map['processType'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
