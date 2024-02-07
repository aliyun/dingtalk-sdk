<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\reservationAuthority;

use AlibabaCloud\Tea\Model;

class authorizedMembers extends Model
{
    /**
     * @example lPHhSZDLXXXXXXpBlC9lxLwiEiE
     *
     * @var string
     */
    public $memberId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $memberName;

    /**
     * @example user
     *
     * @var string
     */
    public $memberType;
    protected $_name = [
        'memberId'   => 'memberId',
        'memberName' => 'memberName',
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
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return authorizedMembers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['memberName'])) {
            $model->memberName = $map['memberName'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }

        return $model;
    }
}
