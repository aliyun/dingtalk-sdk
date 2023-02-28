<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryUserBehaviorResponseBody\data;
use AlibabaCloud\Tea\Model;

class QueryUserBehaviorResponseBody extends Model
{
    /**
     * @description 数据列表
     *
     * @var data[]
     */
    public $data;

    /**
     * @var int
     */
    public $dataCnt;

    /**
     * @var int
     */
    public $totalCnt;
    protected $_name = [
        'data'     => 'data',
        'dataCnt'  => 'dataCnt',
        'totalCnt' => 'totalCnt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dataCnt) {
            $res['dataCnt'] = $this->dataCnt;
        }
        if (null !== $this->totalCnt) {
            $res['totalCnt'] = $this->totalCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserBehaviorResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dataCnt'])) {
            $model->dataCnt = $map['dataCnt'];
        }
        if (isset($map['totalCnt'])) {
            $model->totalCnt = $map['totalCnt'];
        }

        return $model;
    }
}
