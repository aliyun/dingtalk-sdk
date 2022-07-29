<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody\result\list_;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否还有下一页数据。
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 填表实例列表。
     *
     * @var list_[]
     */
    public $list;

    /**
     * @description 下一次分页offset的值。
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'hasMore'   => 'hasMore',
        'list'      => 'list',
        'nextToken' => 'nextToken',
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
        if (null !== $this->list) {
            $res['list'] = [];
            if (null !== $this->list && \is_array($this->list)) {
                $n = 0;
                foreach ($this->list as $item) {
                    $res['list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = [];
                $n           = 0;
                foreach ($map['list'] as $item) {
                    $model->list[$n++] = null !== $item ? list_::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
