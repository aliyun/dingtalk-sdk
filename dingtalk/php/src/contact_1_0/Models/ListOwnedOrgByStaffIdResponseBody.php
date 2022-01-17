<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListOwnedOrgByStaffIdResponseBody\orgList;
use AlibabaCloud\Tea\Model;

class ListOwnedOrgByStaffIdResponseBody extends Model
{
    /**
     * @description 组织列表
     *
     * @var orgList[]
     */
    public $orgList;
    protected $_name = [
        'orgList' => 'orgList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgList) {
            $res['orgList'] = [];
            if (null !== $this->orgList && \is_array($this->orgList)) {
                $n = 0;
                foreach ($this->orgList as $item) {
                    $res['orgList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListOwnedOrgByStaffIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgList'])) {
            if (!empty($map['orgList'])) {
                $model->orgList = [];
                $n              = 0;
                foreach ($map['orgList'] as $item) {
                    $model->orgList[$n++] = null !== $item ? orgList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
