<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList;
use AlibabaCloud\Tea\Model;

class ListStarsResponseBody extends Model
{
    /**
     * @description 分页游标
     * 不为空表示有更多数据
     * @var string
     */
    public $nextToken;

    /**
     * @description 星标数据集合
     * 20
     * @var starList[]
     */
    public $starList;
    protected $_name = [
        'nextToken' => 'nextToken',
        'starList'  => 'starList',
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
        if (null !== $this->starList) {
            $res['starList'] = [];
            if (null !== $this->starList && \is_array($this->starList)) {
                $n = 0;
                foreach ($this->starList as $item) {
                    $res['starList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListStarsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['starList'])) {
            if (!empty($map['starList'])) {
                $model->starList = [];
                $n               = 0;
                foreach ($map['starList'] as $item) {
                    $model->starList[$n++] = null !== $item ? starList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
