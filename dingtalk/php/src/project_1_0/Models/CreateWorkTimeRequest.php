<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkTimeRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @example 2022-09-05
     *
     * @var string
     */
    public $endDate;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $executorId;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $includesHolidays;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isDuration;

    /**
     * @description This parameter is required.
     *
     * @example 63186e54e07f18003fea6b90
     *
     * @var string
     */
    public $objectId;

    /**
     * @description This parameter is required.
     *
     * @example task
     *
     * @var string
     */
    public $objectType;

    /**
     * @description This parameter is required.
     *
     * @example 2022-09-05
     *
     * @var string
     */
    public $startDate;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $submitterId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $workTime;

    /**
     * @description This parameter is required.
     *
     * @example organization
     *
     * @var string
     */
    public $tenantType;
    protected $_name = [
        'description' => 'description',
        'endDate' => 'endDate',
        'executorId' => 'executorId',
        'includesHolidays' => 'includesHolidays',
        'isDuration' => 'isDuration',
        'objectId' => 'objectId',
        'objectType' => 'objectType',
        'startDate' => 'startDate',
        'submitterId' => 'submitterId',
        'workTime' => 'workTime',
        'tenantType' => 'tenantType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->includesHolidays) {
            $res['includesHolidays'] = $this->includesHolidays;
        }
        if (null !== $this->isDuration) {
            $res['isDuration'] = $this->isDuration;
        }
        if (null !== $this->objectId) {
            $res['objectId'] = $this->objectId;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->submitterId) {
            $res['submitterId'] = $this->submitterId;
        }
        if (null !== $this->workTime) {
            $res['workTime'] = $this->workTime;
        }
        if (null !== $this->tenantType) {
            $res['tenantType'] = $this->tenantType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkTimeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['includesHolidays'])) {
            $model->includesHolidays = $map['includesHolidays'];
        }
        if (isset($map['isDuration'])) {
            $model->isDuration = $map['isDuration'];
        }
        if (isset($map['objectId'])) {
            $model->objectId = $map['objectId'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['submitterId'])) {
            $model->submitterId = $map['submitterId'];
        }
        if (isset($map['workTime'])) {
            $model->workTime = $map['workTime'];
        }
        if (isset($map['tenantType'])) {
            $model->tenantType = $map['tenantType'];
        }

        return $model;
    }
}
