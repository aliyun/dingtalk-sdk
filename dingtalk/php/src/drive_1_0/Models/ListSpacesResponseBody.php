<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesResponseBody\spaces;
use AlibabaCloud\Tea\Model;

class ListSpacesResponseBody extends Model
{
    /**
     * @description 分页加载更多锚点, nextToken不为空表示有更多数据
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var spaces[]
     */
    public $spaces;
    protected $_name = [
        'nextToken' => 'nextToken',
        'spaces'    => 'spaces',
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
        if (null !== $this->spaces) {
            $res['spaces'] = [];
            if (null !== $this->spaces && \is_array($this->spaces)) {
                $n = 0;
                foreach ($this->spaces as $item) {
                    $res['spaces'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSpacesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['spaces'])) {
            if (!empty($map['spaces'])) {
                $model->spaces = [];
                $n             = 0;
                foreach ($map['spaces'] as $item) {
                    $model->spaces[$n++] = null !== $item ? spaces::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
