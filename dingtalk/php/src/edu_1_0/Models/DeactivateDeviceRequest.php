<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeactivateDeviceRequest extends Model
{
    /**
     * @example model1
     *
     * @var string
     */
    public $model;

    /**
     * @example fdafds-432432
     *
     * @var string
     */
    public $sn;

    /**
     * @example VIDEO_CALL
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'model' => 'model',
        'sn'    => 'sn',
        'type'  => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeactivateDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
