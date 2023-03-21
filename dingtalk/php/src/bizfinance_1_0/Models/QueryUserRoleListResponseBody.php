<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryUserRoleListResponseBody\roleVOList;
use AlibabaCloud\Tea\Model;

class QueryUserRoleListResponseBody extends Model
{
    /**
     * @var roleVOList[]
     */
    public $roleVOList;
    protected $_name = [
        'roleVOList' => 'roleVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleVOList) {
            $res['roleVOList'] = [];
            if (null !== $this->roleVOList && \is_array($this->roleVOList)) {
                $n = 0;
                foreach ($this->roleVOList as $item) {
                    $res['roleVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserRoleListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleVOList'])) {
            if (!empty($map['roleVOList'])) {
                $model->roleVOList = [];
                $n                 = 0;
                foreach ($map['roleVOList'] as $item) {
                    $model->roleVOList[$n++] = null !== $item ? roleVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
