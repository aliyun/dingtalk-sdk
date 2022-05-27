<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListIndustryRoleUsersRequest extends Model
{
    /**
     * @description 行业角色编码
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'tagCode' => 'tagCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListIndustryRoleUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
