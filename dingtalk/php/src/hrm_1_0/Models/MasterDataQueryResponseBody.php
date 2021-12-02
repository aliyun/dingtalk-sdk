<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result;
use AlibabaCloud\Tea\Model;

class MasterDataQueryResponseBody extends Model
{
    /**
     * @description 总条目数
     *
     * @var int
     */
    public $total;

    /**
     * @description 是否还有更多
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 分页游标
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 结果
     *
     * @var result[]
     */
    public $result;
    protected $_name = [
        'total'     => 'total',
        'hasMore'   => 'hasMore',
        'nextToken' => 'nextToken',
        'success'   => 'success',
        'result'    => 'result',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->result) {
            $res['result'] = [];
            if (null !== $this->result && \is_array($this->result)) {
                $n = 0;
                foreach ($this->result as $item) {
                    $res['result'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MasterDataQueryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['result'])) {
            if (!empty($map['result'])) {
                $model->result = [];
                $n             = 0;
                foreach ($map['result'] as $item) {
                    $model->result[$n++] = null !== $item ? result::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
