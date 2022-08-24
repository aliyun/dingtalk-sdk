<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAccountTransferListResponseBody\itemList;
use AlibabaCloud\Tea\Model;

class GetAccountTransferListResponseBody extends Model
{
    /**
     * @description 迁移详情数据
     *
     * @var itemList[]
     */
    public $itemList;

    /**
     * @description 总数据量
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'itemList'   => 'itemList',
        'totalCount' => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemList) {
            $res['itemList'] = [];
            if (null !== $this->itemList && \is_array($this->itemList)) {
                $n = 0;
                foreach ($this->itemList as $item) {
                    $res['itemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAccountTransferListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemList'])) {
            if (!empty($map['itemList'])) {
                $model->itemList = [];
                $n               = 0;
                foreach ($map['itemList'] as $item) {
                    $model->itemList[$n++] = null !== $item ? itemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
