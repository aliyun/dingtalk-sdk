<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentMembersInfoResponseBody\residenceList;
use AlibabaCloud\Tea\Model;

class GetResidentMembersInfoResponseBody extends Model
{
    /**
     * @description result
     *
     * @var residenceList[]
     */
    public $residenceList;
    protected $_name = [
        'residenceList' => 'residenceList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->residenceList) {
            $res['residenceList'] = [];
            if (null !== $this->residenceList && \is_array($this->residenceList)) {
                $n = 0;
                foreach ($this->residenceList as $item) {
                    $res['residenceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResidentMembersInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['residenceList'])) {
            if (!empty($map['residenceList'])) {
                $model->residenceList = [];
                $n                    = 0;
                foreach ($map['residenceList'] as $item) {
                    $model->residenceList[$n++] = null !== $item ? residenceList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
