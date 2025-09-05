<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateVacationQuotaRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $actionType;

    /**
     * @example 1753851001000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example f84a2829-d245-4312-9ff2-0653e5b3abb2
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @example 2019
     *
     * @var string
     */
    public $quotaCycle;

    /**
     * @var int
     */
    public $quotaNumPerDay;

    /**
     * @var int
     */
    public $quotaNumPerHour;

    /**
     * @var string
     */
    public $reason;

    /**
     * @example 1653851001000
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example user01
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'actionType' => 'actionType',
        'endTime' => 'endTime',
        'leaveCode' => 'leaveCode',
        'quotaCycle' => 'quotaCycle',
        'quotaNumPerDay' => 'quotaNumPerDay',
        'quotaNumPerHour' => 'quotaNumPerHour',
        'reason' => 'reason',
        'startTime' => 'startTime',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->quotaCycle) {
            $res['quotaCycle'] = $this->quotaCycle;
        }
        if (null !== $this->quotaNumPerDay) {
            $res['quotaNumPerDay'] = $this->quotaNumPerDay;
        }
        if (null !== $this->quotaNumPerHour) {
            $res['quotaNumPerHour'] = $this->quotaNumPerHour;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['quotaCycle'])) {
            $model->quotaCycle = $map['quotaCycle'];
        }
        if (isset($map['quotaNumPerDay'])) {
            $model->quotaNumPerDay = $map['quotaNumPerDay'];
        }
        if (isset($map['quotaNumPerHour'])) {
            $model->quotaNumPerHour = $map['quotaNumPerHour'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
