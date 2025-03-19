<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReduceQuotaWithLeaveRecordRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example asdfaad-asdfadfa-asdfa
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description This parameter is required.
     *
     * @example 123342345
     *
     * @var string
     */
    public $outerId;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $quotaNum;

    /**
     * @example 家中有事请假1天
     *
     * @var string
     */
    public $reason;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime' => 'endTime',
        'leaveCode' => 'leaveCode',
        'outerId' => 'outerId',
        'quotaNum' => 'quotaNum',
        'reason' => 'reason',
        'startTime' => 'startTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->outerId) {
            $res['outerId'] = $this->outerId;
        }
        if (null !== $this->quotaNum) {
            $res['quotaNum'] = $this->quotaNum;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReduceQuotaWithLeaveRecordRequest
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
        if (isset($map['outerId'])) {
            $model->outerId = $map['outerId'];
        }
        if (isset($map['quotaNum'])) {
            $model->quotaNum = $map['quotaNum'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
