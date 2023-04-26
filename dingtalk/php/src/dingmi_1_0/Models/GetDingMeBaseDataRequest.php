<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingMeBaseDataRequest extends Model
{
    /**
     * @example dsfsfr434
     *
     * @var string
     */
    public $appKey;

    /**
     * @example true
     *
     * @var bool
     */
    public $byDay;

    /**
     * @example 20210506
     *
     * @var string
     */
    public $endDay;

    /**
     * @example 20210405
     *
     * @var string
     */
    public $startDay;
    protected $_name = [
        'appKey'   => 'appKey',
        'byDay'    => 'byDay',
        'endDay'   => 'endDay',
        'startDay' => 'startDay',
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
        if (null !== $this->byDay) {
            $res['byDay'] = $this->byDay;
        }
        if (null !== $this->endDay) {
            $res['endDay'] = $this->endDay;
        }
        if (null !== $this->startDay) {
            $res['startDay'] = $this->startDay;
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
        if (isset($map['byDay'])) {
            $model->byDay = $map['byDay'];
        }
        if (isset($map['endDay'])) {
            $model->endDay = $map['endDay'];
        }
        if (isset($map['startDay'])) {
            $model->startDay = $map['startDay'];
        }

        return $model;
    }
}
