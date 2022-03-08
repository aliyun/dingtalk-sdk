<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityResponseBody\commodityVOList;
use AlibabaCloud\Tea\Model;

class ListCommodityResponseBody extends Model
{
    /**
     * @description commodityVOList
     *
     * @var commodityVOList[]
     */
    public $commodityVOList;

    /**
     * @description 当前第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 总数量
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'commodityVOList' => 'commodityVOList',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'totalCount'      => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commodityVOList) {
            $res['commodityVOList'] = [];
            if (null !== $this->commodityVOList && \is_array($this->commodityVOList)) {
                $n = 0;
                foreach ($this->commodityVOList as $item) {
                    $res['commodityVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListCommodityResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commodityVOList'])) {
            if (!empty($map['commodityVOList'])) {
                $model->commodityVOList = [];
                $n                      = 0;
                foreach ($map['commodityVOList'] as $item) {
                    $model->commodityVOList[$n++] = null !== $item ? commodityVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
