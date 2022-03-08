<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityResponseBody\list_;
use AlibabaCloud\Tea\Model;

class ListEmpAttributeVisibilityResponseBody extends Model
{
    /**
     * @description 是否还有数据
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 设置列表
     *
     * @var list_[]
     */
    public $list;

    /**
     * @description 下一次拉取时的offset
     *
     * @var int
     */
    public $nextCursor;
    protected $_name = [
        'hasMore'    => 'hasMore',
        'list'       => 'list',
        'nextCursor' => 'nextCursor',
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
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListEmpAttributeVisibilityResponseBody
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
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }

        return $model;
    }
}
