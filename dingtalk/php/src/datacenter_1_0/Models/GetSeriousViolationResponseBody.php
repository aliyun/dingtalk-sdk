<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSeriousViolationResponseBody extends Model
{
    /**
     * @example [     {       "IN_DATE": "xx",       "IN_DEPARTMENT": "xx",       "IN_REASON": "xx"      }   ]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data' => 'data',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSeriousViolationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
