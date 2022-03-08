<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponseBody\result;

use AlibabaCloud\Tea\Model;

class warningSettings extends Model
{
    /**
     * @description 风险预警 或 最大加班时间
     *
     * @var string
     */
    public $action;

    /**
     * @description 提醒阈值
     *
     * @var int
     */
    public $threshold;

    /**
     * @description 预警类型
     *
     * @var string
     */
    public $time;
    protected $_name = [
        'action'    => 'action',
        'threshold' => 'threshold',
        'time'      => 'time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->threshold) {
            $res['threshold'] = $this->threshold;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
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
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['threshold'])) {
            $model->threshold = $map['threshold'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
