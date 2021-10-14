<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListResponseBody\batchTradeDetailList;
use AlibabaCloud\Tea\Model;

class QueryBatchTradeDetailListResponseBody extends Model
{
    /**
     * @description 总记录数
     *
     * @var int
     */
    public $total;

    /**
     * @description 单页条数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 总页数
     *
     * @var int
     */
    public $totalPageNumber;

    /**
     * @description 当前页数
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 明细列表
     *
     * @var batchTradeDetailList[]
     */
    public $batchTradeDetailList;
    protected $_name = [
        'total'                => 'total',
        'pageSize'             => 'pageSize',
        'totalPageNumber'      => 'totalPageNumber',
        'pageNumber'           => 'pageNumber',
        'batchTradeDetailList' => 'batchTradeDetailList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->totalPageNumber) {
            $res['totalPageNumber'] = $this->totalPageNumber;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->batchTradeDetailList) {
            $res['batchTradeDetailList'] = [];
            if (null !== $this->batchTradeDetailList && \is_array($this->batchTradeDetailList)) {
                $n = 0;
                foreach ($this->batchTradeDetailList as $item) {
                    $res['batchTradeDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBatchTradeDetailListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['totalPageNumber'])) {
            $model->totalPageNumber = $map['totalPageNumber'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['batchTradeDetailList'])) {
            if (!empty($map['batchTradeDetailList'])) {
                $model->batchTradeDetailList = [];
                $n                           = 0;
                foreach ($map['batchTradeDetailList'] as $item) {
                    $model->batchTradeDetailList[$n++] = null !== $item ? batchTradeDetailList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
