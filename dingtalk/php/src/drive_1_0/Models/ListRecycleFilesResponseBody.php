<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesResponseBody\recycleItems;
use AlibabaCloud\Tea\Model;

class ListRecycleFilesResponseBody extends Model
{
    /**
     * @description 加载更多锚点, nextToken不为空表示有更多数据
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 回收站文件列表
     *
     * @var recycleItems[]
     */
    public $recycleItems;
    protected $_name = [
        'nextToken'    => 'nextToken',
        'recycleItems' => 'recycleItems',
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
        if (null !== $this->recycleItems) {
            $res['recycleItems'] = [];
            if (null !== $this->recycleItems && \is_array($this->recycleItems)) {
                $n = 0;
                foreach ($this->recycleItems as $item) {
                    $res['recycleItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRecycleFilesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['recycleItems'])) {
            if (!empty($map['recycleItems'])) {
                $model->recycleItems = [];
                $n                   = 0;
                foreach ($map['recycleItems'] as $item) {
                    $model->recycleItems[$n++] = null !== $item ? recycleItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
