<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserByUnionIdResponseBody extends Model
{
    /**
     * @description 联系类型，0表示企业内部员工，1表示企业外部联系人
     *
     * @var int
     */
    public $contactType;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'contactType' => 'contactType',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactType) {
            $res['contactType'] = $this->contactType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserByUnionIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactType'])) {
            $model->contactType = $map['contactType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
