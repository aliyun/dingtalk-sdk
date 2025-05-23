<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveFinishRequest;

use AlibabaCloud\Tea\Model;

class topCalculateApproveDurationParam extends Model
{
    /**
     * @example 3
     *
     * @var int
     */
    public $bizType;

    /**
     * @example 1
     *
     * @var int
     */
    public $calculateModel;

    /**
     * @example day
     *
     * @var string
     */
    public $durationUnit;

    /**
     * @example 2019-08-15
     *
     * @var string
     */
    public $fromTime;

    /**
     * @example 3afdsf-143dsadw3-ad23
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @example 2019-08-15
     *
     * @var string
     */
    public $toTime;
    protected $_name = [
        'bizType' => 'bizType',
        'calculateModel' => 'calculateModel',
        'durationUnit' => 'durationUnit',
        'fromTime' => 'fromTime',
        'leaveCode' => 'leaveCode',
        'toTime' => 'toTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->calculateModel) {
            $res['calculateModel'] = $this->calculateModel;
        }
        if (null !== $this->durationUnit) {
            $res['durationUnit'] = $this->durationUnit;
        }
        if (null !== $this->fromTime) {
            $res['fromTime'] = $this->fromTime;
        }
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->toTime) {
            $res['toTime'] = $this->toTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topCalculateApproveDurationParam
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['calculateModel'])) {
            $model->calculateModel = $map['calculateModel'];
        }
        if (isset($map['durationUnit'])) {
            $model->durationUnit = $map['durationUnit'];
        }
        if (isset($map['fromTime'])) {
            $model->fromTime = $map['fromTime'];
        }
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['toTime'])) {
            $model->toTime = $map['toTime'];
        }

        return $model;
    }
}
