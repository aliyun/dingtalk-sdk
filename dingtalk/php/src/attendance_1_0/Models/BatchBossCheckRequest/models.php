<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\BatchBossCheckRequest;

use AlibabaCloud\Tea\Model;

class models extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $absentMin;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var int
     */
    public $planId;

    /**
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example Normal
     *
     * @var string
     */
    public $timeResult;
    protected $_name = [
        'absentMin'  => 'absentMin',
        'planId'     => 'planId',
        'remark'     => 'remark',
        'timeResult' => 'timeResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->absentMin) {
            $res['absentMin'] = $this->absentMin;
        }
        if (null !== $this->planId) {
            $res['planId'] = $this->planId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->timeResult) {
            $res['timeResult'] = $this->timeResult;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return models
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['absentMin'])) {
            $model->absentMin = $map['absentMin'];
        }
        if (isset($map['planId'])) {
            $model->planId = $map['planId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['timeResult'])) {
            $model->timeResult = $map['timeResult'];
        }

        return $model;
    }
}
