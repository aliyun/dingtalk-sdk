<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\InitAndGetLeaveALlocationQuotasResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1753851001000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example c00ced14-xxxxxd438748
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @example 2022
     *
     * @var string
     */
    public $quotaCycle;

    /**
     * @example b13cc5b0--xxxx5b0
     *
     * @var string
     */
    public $quotaId;

    /**
     * @example 700
     *
     * @var int
     */
    public $quotaNumPerDay;

    /**
     * @example 800
     *
     * @var int
     */
    public $quotaNumPerHour;

    /**
     * @example 1653851001000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 200
     *
     * @var int
     */
    public $usedNumPerDay;

    /**
     * @example 100
     *
     * @var int
     */
    public $usedNumPerHour;

    /**
     * @example user1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'endTime'         => 'endTime',
        'leaveCode'       => 'leaveCode',
        'quotaCycle'      => 'quotaCycle',
        'quotaId'         => 'quotaId',
        'quotaNumPerDay'  => 'quotaNumPerDay',
        'quotaNumPerHour' => 'quotaNumPerHour',
        'startTime'       => 'startTime',
        'usedNumPerDay'   => 'usedNumPerDay',
        'usedNumPerHour'  => 'usedNumPerHour',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->quotaCycle) {
            $res['quotaCycle'] = $this->quotaCycle;
        }
        if (null !== $this->quotaId) {
            $res['quotaId'] = $this->quotaId;
        }
        if (null !== $this->quotaNumPerDay) {
            $res['quotaNumPerDay'] = $this->quotaNumPerDay;
        }
        if (null !== $this->quotaNumPerHour) {
            $res['quotaNumPerHour'] = $this->quotaNumPerHour;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->usedNumPerDay) {
            $res['usedNumPerDay'] = $this->usedNumPerDay;
        }
        if (null !== $this->usedNumPerHour) {
            $res['usedNumPerHour'] = $this->usedNumPerHour;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['quotaCycle'])) {
            $model->quotaCycle = $map['quotaCycle'];
        }
        if (isset($map['quotaId'])) {
            $model->quotaId = $map['quotaId'];
        }
        if (isset($map['quotaNumPerDay'])) {
            $model->quotaNumPerDay = $map['quotaNumPerDay'];
        }
        if (isset($map['quotaNumPerHour'])) {
            $model->quotaNumPerHour = $map['quotaNumPerHour'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['usedNumPerDay'])) {
            $model->usedNumPerDay = $map['usedNumPerDay'];
        }
        if (isset($map['usedNumPerHour'])) {
            $model->usedNumPerHour = $map['usedNumPerHour'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
