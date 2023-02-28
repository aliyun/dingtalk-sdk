<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems;
use AlibabaCloud\Tea\Model;

class ListPinSpacesResponseBody extends Model
{
    /**
     * @description 分页游标
     * 不为空表示有更多数据
     * @var string
     */
    public $nextToken;

    /**
     * @description 知识库置顶数据集合
     * 20
     * @var resultItems[]
     */
    public $resultItems;
    protected $_name = [
        'nextToken'   => 'nextToken',
        'resultItems' => 'resultItems',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->resultItems) {
            $res['resultItems'] = [];
            if (null !== $this->resultItems && \is_array($this->resultItems)) {
                $n = 0;
                foreach ($this->resultItems as $item) {
                    $res['resultItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPinSpacesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['resultItems'])) {
            if (!empty($map['resultItems'])) {
                $model->resultItems = [];
                $n                  = 0;
                foreach ($map['resultItems'] as $item) {
                    $model->resultItems[$n++] = null !== $item ? resultItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
