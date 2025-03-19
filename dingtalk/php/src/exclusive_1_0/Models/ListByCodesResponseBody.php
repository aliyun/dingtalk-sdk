<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByCodesResponseBody\robotInfoList;
use AlibabaCloud\Tea\Model;

class ListByCodesResponseBody extends Model
{
    /**
     * @var robotInfoList[]
     */
    public $robotInfoList;
    protected $_name = [
        'robotInfoList' => 'robotInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotInfoList) {
            $res['robotInfoList'] = [];
            if (null !== $this->robotInfoList && \is_array($this->robotInfoList)) {
                $n = 0;
                foreach ($this->robotInfoList as $item) {
                    $res['robotInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListByCodesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotInfoList'])) {
            if (!empty($map['robotInfoList'])) {
                $model->robotInfoList = [];
                $n = 0;
                foreach ($map['robotInfoList'] as $item) {
                    $model->robotInfoList[$n++] = null !== $item ? robotInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
