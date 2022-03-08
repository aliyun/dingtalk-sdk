<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemsByKeyWordResponseBody\value;
use AlibabaCloud\Tea\Model;

class GetSearchItemsByKeyWordResponseBody extends Model
{
    /**
     * @description 下一次请求的加密offset，若为空则代表item已经读取完毕
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 本次请求条件下的item总量
     *
     * @var int
     */
    public $totalCount;

    /**
     * @var value[]
     */
    public $value;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'totalCount' => 'totalCount',
        'value'      => 'value',
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
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->value) {
            $res['value'] = [];
            if (null !== $this->value && \is_array($this->value)) {
                $n = 0;
                foreach ($this->value as $item) {
                    $res['value'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSearchItemsByKeyWordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = [];
                $n            = 0;
                foreach ($map['value'] as $item) {
                    $model->value[$n++] = null !== $item ? value::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
