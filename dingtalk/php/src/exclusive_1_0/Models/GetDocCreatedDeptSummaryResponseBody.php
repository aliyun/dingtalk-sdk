<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetDocCreatedDeptSummaryResponseBody extends Model
{
    /**
     * @description 部门维度用户创建文档数
     *
     * @var data[]
     */
    public $data;

    /**
     * @description 下一次请求的分页游标
     *
     * @var int
     */
    public $nextId;

    /**
     * @description 是否有更多数据
     *
     * @var bool
     */
    public $hasMore;
    protected $_name = [
        'data'    => 'data',
        'nextId'  => 'nextId',
        'hasMore' => 'hasMore',
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
        if (null !== $this->nextId) {
            $res['nextId'] = $this->nextId;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDocCreatedDeptSummaryResponseBody
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
        if (isset($map['nextId'])) {
            $model->nextId = $map['nextId'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }

        return $model;
    }
}
