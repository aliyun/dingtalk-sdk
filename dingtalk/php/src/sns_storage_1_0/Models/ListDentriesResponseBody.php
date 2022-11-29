<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesResponseBody\dentries;
use AlibabaCloud\Tea\Model;

class ListDentriesResponseBody extends Model
{
    /**
     * @description 文件列表
     * 50
     * @var dentries[]
     */
    public $dentries;

    /**
     * @description 分页游标
     * 不为空表示有更多数据
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'dentries'  => 'dentries',
        'nextToken' => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentries) {
            $res['dentries'] = [];
            if (null !== $this->dentries && \is_array($this->dentries)) {
                $n = 0;
                foreach ($this->dentries as $item) {
                    $res['dentries'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return ListDentriesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentries'])) {
            if (!empty($map['dentries'])) {
                $model->dentries = [];
                $n               = 0;
                foreach ($map['dentries'] as $item) {
                    $model->dentries[$n++] = null !== $item ? dentries::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
