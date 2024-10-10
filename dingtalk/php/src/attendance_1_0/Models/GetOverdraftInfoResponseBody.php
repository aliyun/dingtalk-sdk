<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOverdraftInfoResponseBody\overdraftList;
use AlibabaCloud\Tea\Model;

class GetOverdraftInfoResponseBody extends Model
{
    /**
     * @var overdraftList[]
     */
    public $overdraftList;
    protected $_name = [
        'overdraftList' => 'overdraftList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->overdraftList) {
            $res['overdraftList'] = [];
            if (null !== $this->overdraftList && \is_array($this->overdraftList)) {
                $n = 0;
                foreach ($this->overdraftList as $item) {
                    $res['overdraftList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOverdraftInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['overdraftList'])) {
            if (!empty($map['overdraftList'])) {
                $model->overdraftList = [];
                $n                    = 0;
                foreach ($map['overdraftList'] as $item) {
                    $model->overdraftList[$n++] = null !== $item ? overdraftList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
