<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponseBody\failMemberInfoList;
use AlibabaCloud\Tea\Model;

class UpdatePermissionResponseBody extends Model
{
    /**
     * @var failMemberInfoList[]
     */
    public $failMemberInfoList;
    protected $_name = [
        'failMemberInfoList' => 'failMemberInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failMemberInfoList) {
            $res['failMemberInfoList'] = [];
            if (null !== $this->failMemberInfoList && \is_array($this->failMemberInfoList)) {
                $n = 0;
                foreach ($this->failMemberInfoList as $item) {
                    $res['failMemberInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failMemberInfoList'])) {
            if (!empty($map['failMemberInfoList'])) {
                $model->failMemberInfoList = [];
                $n = 0;
                foreach ($map['failMemberInfoList'] as $item) {
                    $model->failMemberInfoList[$n++] = null !== $item ? failMemberInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
