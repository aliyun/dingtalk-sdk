<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeRequest;

use AlibabaCloud\Tea\Model;

class leaveCertificate extends Model
{
    /**
     * @example 1
     *
     * @var float
     */
    public $duration;

    /**
     * @example false
     *
     * @var bool
     */
    public $enable;

    /**
     * @example 请假文案
     *
     * @var string
     */
    public $promptInformation;

    /**
     * @example hour
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'duration'          => 'duration',
        'enable'            => 'enable',
        'promptInformation' => 'promptInformation',
        'unit'              => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->enable) {
            $res['enable'] = $this->enable;
        }
        if (null !== $this->promptInformation) {
            $res['promptInformation'] = $this->promptInformation;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return leaveCertificate
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
        }
        if (isset($map['promptInformation'])) {
            $model->promptInformation = $map['promptInformation'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
