<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetExclusiveAccountAllOrgListResponseBody\orgInfoList;
use AlibabaCloud\Tea\Model;

class GetExclusiveAccountAllOrgListResponseBody extends Model
{
    /**
     * @description 组织信息列表
     *
     * @var orgInfoList[]
     */
    public $orgInfoList;
    protected $_name = [
        'orgInfoList' => 'orgInfoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgInfoList) {
            $res['orgInfoList'] = [];
            if (null !== $this->orgInfoList && \is_array($this->orgInfoList)) {
                $n = 0;
                foreach ($this->orgInfoList as $item) {
                    $res['orgInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetExclusiveAccountAllOrgListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgInfoList'])) {
            if (!empty($map['orgInfoList'])) {
                $model->orgInfoList = [];
                $n                  = 0;
                foreach ($map['orgInfoList'] as $item) {
                    $model->orgInfoList[$n++] = null !== $item ? orgInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
