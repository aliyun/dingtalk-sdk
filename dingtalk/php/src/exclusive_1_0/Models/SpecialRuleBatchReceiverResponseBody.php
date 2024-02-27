<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverResponseBody\data;
use AlibabaCloud\Tea\Model;

class SpecialRuleBatchReceiverResponseBody extends Model
{
    /**
     * @var int
     */
    public $code;

    /**
     * @var data[]
     */
    public $data;

    /**
     * @var string
     */
    public $msg;

    /**
     * @var string
     */
    public $msgId;

    /**
     * @var undefined[][]
     */
    public $rows;
    protected $_name = [
        'code'  => 'code',
        'data'  => 'data',
        'msg'   => 'msg',
        'msgId' => 'msgId',
        'rows'  => 'rows',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }
        if (null !== $this->rows) {
            $res['rows'] = $this->rows;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SpecialRuleBatchReceiverResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }
        if (isset($map['rows'])) {
            if (!empty($map['rows'])) {
                $model->rows = $map['rows'];
            }
        }

        return $model;
    }
}
