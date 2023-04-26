<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeResponseBody\result;

use AlibabaCloud\Tea\Model;

class submitTimeRule extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $enableTimeLimit;

    /**
     * @example before
     *
     * @var string
     */
    public $timeType;

    /**
     * @example day
     *
     * @var string
     */
    public $timeUnit;

    /**
     * @example 1
     *
     * @var int
     */
    public $timeValue;
    protected $_name = [
        'enableTimeLimit' => 'enableTimeLimit',
        'timeType'        => 'timeType',
        'timeUnit'        => 'timeUnit',
        'timeValue'       => 'timeValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableTimeLimit) {
            $res['enableTimeLimit'] = $this->enableTimeLimit;
        }
        if (null !== $this->timeType) {
            $res['timeType'] = $this->timeType;
        }
        if (null !== $this->timeUnit) {
            $res['timeUnit'] = $this->timeUnit;
        }
        if (null !== $this->timeValue) {
            $res['timeValue'] = $this->timeValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return submitTimeRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enableTimeLimit'])) {
            $model->enableTimeLimit = $map['enableTimeLimit'];
        }
        if (isset($map['timeType'])) {
            $model->timeType = $map['timeType'];
        }
        if (isset($map['timeUnit'])) {
            $model->timeUnit = $map['timeUnit'];
        }
        if (isset($map['timeValue'])) {
            $model->timeValue = $map['timeValue'];
        }

        return $model;
    }
}
