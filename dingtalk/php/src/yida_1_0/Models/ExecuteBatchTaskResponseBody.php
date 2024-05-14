<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecuteBatchTaskResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $failNumber;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $successNumber;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'failNumber'    => 'failNumber',
        'successNumber' => 'successNumber',
        'total'         => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failNumber) {
            $res['failNumber'] = $this->failNumber;
        }
        if (null !== $this->successNumber) {
            $res['successNumber'] = $this->successNumber;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteBatchTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failNumber'])) {
            $model->failNumber = $map['failNumber'];
        }
        if (isset($map['successNumber'])) {
            $model->successNumber = $map['successNumber'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
