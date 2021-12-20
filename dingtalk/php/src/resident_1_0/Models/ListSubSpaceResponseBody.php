<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListSubSpaceResponseBody\spaceList;
use AlibabaCloud\Tea\Model;

class ListSubSpaceResponseBody extends Model
{
    /**
     * @description result
     *
     * @var spaceList[]
     */
    public $spaceList;
    protected $_name = [
        'spaceList' => 'spaceList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceList) {
            $res['spaceList'] = [];
            if (null !== $this->spaceList && \is_array($this->spaceList)) {
                $n = 0;
                foreach ($this->spaceList as $item) {
                    $res['spaceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubSpaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceList'])) {
            if (!empty($map['spaceList'])) {
                $model->spaceList = [];
                $n                = 0;
                foreach ($map['spaceList'] as $item) {
                    $model->spaceList[$n++] = null !== $item ? spaceList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
