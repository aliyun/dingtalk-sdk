<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupAdminResponseBody\result;

use AlibabaCloud\Tea\Model;

class groupAdmins extends Model
{
    /**
     * @var string
     */
    public $memberId;

    /**
     * @var string
     */
    public $memberName;
    protected $_name = [
        'memberId' => 'memberId',
        'memberName' => 'memberName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupAdmins
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

        return $model;
    }
}
