<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUserIndustryRolesResponseBody\roleList;
use AlibabaCloud\Tea\Model;

class ListUserIndustryRolesResponseBody extends Model
{
    /**
     * @description result
     *
     * @var roleList[]
     */
    public $roleList;
    protected $_name = [
        'roleList' => 'roleList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleList) {
            $res['roleList'] = [];
            if (null !== $this->roleList && \is_array($this->roleList)) {
                $n = 0;
                foreach ($this->roleList as $item) {
                    $res['roleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListUserIndustryRolesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleList'])) {
            if (!empty($map['roleList'])) {
                $model->roleList = [];
                $n               = 0;
                foreach ($map['roleList'] as $item) {
                    $model->roleList[$n++] = null !== $item ? roleList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
