<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkTimeRequest extends Model
{
    /**
     * @description 结束时间
     *
     * @var string
     */
    public $endDate;

    /**
     * @description 是否包含节假日
     *
     * @var bool
     */
    public $includesHolidays;

    /**
     * @description 是否连续
     *
     * @var bool
     */
    public $isDuration;

    /**
     * @description 对象 ID，比如 任务 ID
     *
     * @var string
     */
    public $objectId;

    /**
     * @description 对象类型，默认为 task
     *
     * @var string
     */
    public $objectType;

    /**
     * @description 操作者用户id
     *
     * @var string
     */
    public $optUser;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 工时提交人员用户id
     *
     * @var string
     */
    public $submitterId;

    /**
     * @description 实际工时数（单位毫秒，1小时即为3600000）
     *
     * @var int
     */
    public $workTime;

    /**
     * @var string
     */
    public $tenantType;
    protected $_name = [
        'endDate'          => 'endDate',
        'includesHolidays' => 'includesHolidays',
        'isDuration'       => 'isDuration',
        'objectId'         => 'objectId',
        'objectType'       => 'objectType',
        'optUser'          => 'optUser',
        'startDate'        => 'startDate',
        'submitterId'      => 'submitterId',
        'workTime'         => 'workTime',
        'tenantType'       => 'tenantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
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
        if (null !== $this->optUser) {
            $res['optUser'] = $this->optUser;
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
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
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
        if (isset($map['optUser'])) {
            $model->optUser = $map['optUser'];
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
