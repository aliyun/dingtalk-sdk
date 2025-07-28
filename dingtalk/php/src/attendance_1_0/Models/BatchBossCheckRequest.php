<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\BatchBossCheckRequest\models;
use AlibabaCloud\Tea\Model;

class BatchBossCheckRequest extends Model
{
    /**
     * @var models[]
     */
    public $models;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'models' => 'models',
        'opUserId' => 'opUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->models) {
            $res['models'] = [];
            if (null !== $this->models && \is_array($this->models)) {
                $n = 0;
                foreach ($this->models as $item) {
                    $res['models'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchBossCheckRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['models'])) {
            if (!empty($map['models'])) {
                $model->models = [];
                $n = 0;
                foreach ($map['models'] as $item) {
                    $model->models[$n++] = null !== $item ? models::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
