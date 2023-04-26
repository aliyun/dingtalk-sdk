<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListResponseBody\batchTradeDetailList;
use AlibabaCloud\Tea\Model;

class QueryBatchTradeDetailListResponseBody extends Model
{
    /**
     * @var batchTradeDetailList[]
     */
    public $batchTradeDetailList;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 1
     *
     * @var int
     */
    public $total;

    /**
     * @example 1
     *
     * @var int
     */
    public $totalPageNumber;
    protected $_name = [
        'batchTradeDetailList' => 'batchTradeDetailList',
        'pageNumber'           => 'pageNumber',
        'pageSize'             => 'pageSize',
        'total'                => 'total',
        'totalPageNumber'      => 'totalPageNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->batchTradeDetailList) {
            $res['batchTradeDetailList'] = [];
            if (null !== $this->batchTradeDetailList && \is_array($this->batchTradeDetailList)) {
                $n = 0;
                foreach ($this->batchTradeDetailList as $item) {
                    $res['batchTradeDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }
        if (null !== $this->totalPageNumber) {
            $res['totalPageNumber'] = $this->totalPageNumber;
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
        if (isset($map['batchTradeDetailList'])) {
            if (!empty($map['batchTradeDetailList'])) {
                $model->batchTradeDetailList = [];
                $n                           = 0;
                foreach ($map['batchTradeDetailList'] as $item) {
                    $model->batchTradeDetailList[$n++] = null !== $item ? batchTradeDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }
        if (isset($map['totalPageNumber'])) {
            $model->totalPageNumber = $map['totalPageNumber'];
        }

        return $model;
    }
}
