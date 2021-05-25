<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 成员类型
     *
     * @var string
     */
    public $memberType;

    /**
     * @description 成员id
     *
     * @var string
     */
    public $memberId;
    protected $_name = [
        'memberType' => 'memberType',
        'memberId'   => 'memberId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return members
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }

        return $model;
    }
}
