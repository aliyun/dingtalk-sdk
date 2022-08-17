<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTbOrgIdByDingOrgIdRequest extends Model
{
    /**
     * @description 操作者userId
     *
     * @var string
     */
    public $optUserId;
    protected $_name = [
        'optUserId' => 'optUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTbOrgIdByDingOrgIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }

        return $model;
    }
}
