<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponseBody\result;

use AlibabaCloud\Tea\Model;

class warningSettings extends Model
{
    /**
     * @description 预警类型
     *
     * @var string
     */
    public $time;

    /**
     * @description 提醒阈值
     *
     * @var int
     */
    public $threshold;

    /**
     * @description 风险预警 或 最大加班时间
     *
     * @var string
     */
    public $action;
    protected $_name = [
        'time'      => 'time',
        'threshold' => 'threshold',
        'action'    => 'action',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->threshold) {
            $res['threshold'] = $this->threshold;
        }
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return warningSettings
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['threshold'])) {
            $model->threshold = $map['threshold'];
        }
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }

        return $model;
    }
}
