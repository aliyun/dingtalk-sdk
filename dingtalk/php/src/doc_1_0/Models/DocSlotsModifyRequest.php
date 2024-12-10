<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsModifyRequest\request;
use AlibabaCloud\Tea\Model;

class DocSlotsModifyRequest extends Model
{
    /**
     * @example contentBody
     *
     * @var request[]
     */
    public $request;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'request'    => 'request',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->request) {
            $res['request'] = [];
            if (null !== $this->request && \is_array($this->request)) {
                $n = 0;
                foreach ($this->request as $item) {
                    $res['request'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return DocSlotsModifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['request'])) {
            if (!empty($map['request'])) {
                $model->request = [];
                $n              = 0;
                foreach ($map['request'] as $item) {
                    $model->request[$n++] = null !== $item ? request::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
