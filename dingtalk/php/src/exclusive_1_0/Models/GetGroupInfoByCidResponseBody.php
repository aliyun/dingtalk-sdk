<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupInfoByCidResponseBody\groupInfo;
use AlibabaCloud\Tea\Model;

class GetGroupInfoByCidResponseBody extends Model
{
    /**
     * @var groupInfo
     */
    public $groupInfo;
    protected $_name = [
        'groupInfo' => 'groupInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupInfo) {
            $res['groupInfo'] = null !== $this->groupInfo ? $this->groupInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGroupInfoByCidResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupInfo'])) {
            $model->groupInfo = groupInfo::fromMap($map['groupInfo']);
        }

        return $model;
    }
}
