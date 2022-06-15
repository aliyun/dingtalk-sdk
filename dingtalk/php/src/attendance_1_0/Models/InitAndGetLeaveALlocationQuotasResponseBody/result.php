<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\InitAndGetLeaveALlocationQuotasResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 额度有效期结束时间。
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 假期类型标识。
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description 年度。
     *
     * @var string
     */
    public $quotaCycle;

    /**
     * @description 余额标识。
     *
     * @var string
     */
    public $quotaId;

    /**
     * @description 以天计算额度总数。
     *
     * @var int
     */
    public $quotaNumPerDay;

    /**
     * @description 以小时计算额度总数。
     *
     * @var int
     */
    public $quotaNumPerHour;

    /**
     * @description 额度有效期开始时间。
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 用过的配额天数。
     *
     * @var int
     */
    public $usedNumPerDay;

    /**
     * @description 用过的配额小时数。
     *
     * @var int
     */
    public $usedNumPerHour;

    /**
     * @description 用户id。
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
