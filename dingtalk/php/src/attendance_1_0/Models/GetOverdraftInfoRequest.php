<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOverdraftInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'leaveCode'  => 'leaveCode',
        'userIdList' => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOverdraftInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
