<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsResponseBody\corpList;
use AlibabaCloud\Tea\Model;

class ListSubCorpsResponseBody extends Model
{
    /**
     * @description result
     *
     * @var corpList[]
     */
    public $corpList;
    protected $_name = [
        'corpList' => 'corpList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpList) {
            $res['corpList'] = [];
            if (null !== $this->corpList && \is_array($this->corpList)) {
                $n = 0;
                foreach ($this->corpList as $item) {
                    $res['corpList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubCorpsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpList'])) {
            if (!empty($map['corpList'])) {
                $model->corpList = [];
                $n               = 0;
                foreach ($map['corpList'] as $item) {
                    $model->corpList[$n++] = null !== $item ? corpList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
