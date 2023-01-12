<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetPublicDevicesResponseBody extends Model
{
    /**
     * @var data[]
     */
    public $data;

    /**
     * @description 当前页条目数
     *
     * @var int
     */
    public $dataCnt;

    /**
     * @description 总条目数
     *
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
     * @return GetPublicDevicesResponseBody
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
