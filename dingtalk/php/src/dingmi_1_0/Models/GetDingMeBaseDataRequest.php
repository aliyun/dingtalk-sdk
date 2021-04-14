<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingMeBaseDataRequest extends Model
{
    /**
     * @description 机器人ID
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $startDay;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $endDay;

    /**
     * @description 是否按天分组
     *
     * @var bool
     */
    public $byDay;
    protected $_name = [
        'appKey'   => 'appKey',
        'startDay' => 'startDay',
        'endDay'   => 'endDay',
        'byDay'    => 'byDay',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->startDay) {
            $res['startDay'] = $this->startDay;
        }
        if (null !== $this->endDay) {
            $res['endDay'] = $this->endDay;
        }
        if (null !== $this->byDay) {
            $res['byDay'] = $this->byDay;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingMeBaseDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['startDay'])) {
            $model->startDay = $map['startDay'];
        }
        if (isset($map['endDay'])) {
            $model->endDay = $map['endDay'];
        }
        if (isset($map['byDay'])) {
            $model->byDay = $map['byDay'];
        }

        return $model;
    }
}
