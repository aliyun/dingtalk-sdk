<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchRequest\requests;
use AlibabaCloud\Tea\Model;

class BatchRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var requests[]
     */
    public $requests;

    /**
     * @description This parameter is required.
     *
     * @example ppgAQuHxxxxx
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'requests'   => 'requests',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requests) {
            $res['requests'] = [];
            if (null !== $this->requests && \is_array($this->requests)) {
                $n = 0;
                foreach ($this->requests as $item) {
                    $res['requests'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requests'])) {
            if (!empty($map['requests'])) {
                $model->requests = [];
                $n               = 0;
                foreach ($map['requests'] as $item) {
                    $model->requests[$n++] = null !== $item ? requests::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
