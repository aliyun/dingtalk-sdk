<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserBindDeviceLocationShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $userIdListShrink;
    protected $_name = [
        'userIdListShrink' => 'userIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->userIdListShrink) {
            $res['userIdList'] = $this->userIdListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserBindDeviceLocationShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userIdList'])) {
            $model->userIdListShrink = $map['userIdList'];
        }

        return $model;
    }
}
