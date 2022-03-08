<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryResponseBody\data;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryResponseBody\publisherArticlePvTop5;
use AlibabaCloud\Tea\Model;

class GetPublisherSummaryResponseBody extends Model
{
    /**
     * @description 互动服务窗相关数据
     *
     * @var data[]
     */
    public $data;

    /**
     * @description 是否有更多数据
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下一次请求的分页游标
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 历史截至当日服务窗文章数
     *
     * @var string
     */
    public $publisherArticleCntStd;

    /**
     * @description 历史截至当日服务窗文章阅读数
     *
     * @var string
     */
    public $publisherArticlePvCntStd;

    /**
     * @description 阅读量最高的5个文章
     *
     * @var publisherArticlePvTop5[]
     */
    public $publisherArticlePvTop5;

    /**
     * @description 历史截至当日服务窗数
     *
     * @var string
     */
    public $publisherCntStd;
    protected $_name = [
        'data'                     => 'data',
        'hasMore'                  => 'hasMore',
        'nextToken'                => 'nextToken',
        'publisherArticleCntStd'   => 'publisherArticleCntStd',
        'publisherArticlePvCntStd' => 'publisherArticlePvCntStd',
        'publisherArticlePvTop5'   => 'publisherArticlePvTop5',
        'publisherCntStd'          => 'publisherCntStd',
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
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->publisherArticleCntStd) {
            $res['publisherArticleCntStd'] = $this->publisherArticleCntStd;
        }
        if (null !== $this->publisherArticlePvCntStd) {
            $res['publisherArticlePvCntStd'] = $this->publisherArticlePvCntStd;
        }
        if (null !== $this->publisherArticlePvTop5) {
            $res['publisherArticlePvTop5'] = [];
            if (null !== $this->publisherArticlePvTop5 && \is_array($this->publisherArticlePvTop5)) {
                $n = 0;
                foreach ($this->publisherArticlePvTop5 as $item) {
                    $res['publisherArticlePvTop5'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->publisherCntStd) {
            $res['publisherCntStd'] = $this->publisherCntStd;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPublisherSummaryResponseBody
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
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['publisherArticleCntStd'])) {
            $model->publisherArticleCntStd = $map['publisherArticleCntStd'];
        }
        if (isset($map['publisherArticlePvCntStd'])) {
            $model->publisherArticlePvCntStd = $map['publisherArticlePvCntStd'];
        }
        if (isset($map['publisherArticlePvTop5'])) {
            if (!empty($map['publisherArticlePvTop5'])) {
                $model->publisherArticlePvTop5 = [];
                $n                             = 0;
                foreach ($map['publisherArticlePvTop5'] as $item) {
                    $model->publisherArticlePvTop5[$n++] = null !== $item ? publisherArticlePvTop5::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['publisherCntStd'])) {
            $model->publisherCntStd = $map['publisherCntStd'];
        }

        return $model;
    }
}
