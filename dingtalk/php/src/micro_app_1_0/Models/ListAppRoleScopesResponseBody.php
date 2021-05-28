<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAppRoleScopesResponseBody\dataList;
use AlibabaCloud\Tea\Model;

class ListAppRoleScopesResponseBody extends Model
{
    /**
     * @description 是否还有数据，true: 还有；false: 已经全部拉取完成
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下一次请求的起始点
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 数据列表
     *
     * @var dataList[]
     */
    public $dataList;
    protected $_name = [
        'hasMore'   => 'hasMore',
        'nextToken' => 'nextToken',
        'dataList'  => 'dataList',
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
        if (null !== $this->dataList) {
            $res['dataList'] = [];
            if (null !== $this->dataList && \is_array($this->dataList)) {
                $n = 0;
                foreach ($this->dataList as $item) {
                    $res['dataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAppRoleScopesResponseBody
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
        if (isset($map['dataList'])) {
            if (!empty($map['dataList'])) {
                $model->dataList = [];
                $n               = 0;
                foreach ($map['dataList'] as $item) {
                    $model->dataList[$n++] = null !== $item ? dataList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
