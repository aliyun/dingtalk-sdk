<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdResponseBody\resultList;
use AlibabaCloud\Tea\Model;

class GetCustomerTracksByRelationIdResponseBody extends Model
{
    /**
     * @description 是否还有下一页。
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下一页的游标。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 数据列表。
     *
     * @var resultList[]
     */
    public $resultList;
    protected $_name = [
        'hasMore'    => 'hasMore',
        'nextToken'  => 'nextToken',
        'resultList' => 'resultList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->resultList) {
            $res['resultList'] = [];
            if (null !== $this->resultList && \is_array($this->resultList)) {
                $n = 0;
                foreach ($this->resultList as $item) {
                    $res['resultList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCustomerTracksByRelationIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['resultList'])) {
            if (!empty($map['resultList'])) {
                $model->resultList = [];
                $n                 = 0;
                foreach ($map['resultList'] as $item) {
                    $model->resultList[$n++] = null !== $item ? resultList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
