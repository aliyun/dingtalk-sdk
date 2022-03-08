<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 成员id
     *
     * @var string
     */
    public $memberId;

    /**
     * @description 成员类型
     *
     * @var string
     */
    public $memberType;
    protected $_name = [
        'memberId'   => 'memberId',
        'memberType' => 'memberType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
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
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }

        return $model;
    }
}
