<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class InitAndGetLeaveALlocationQuotasRequest extends Model
{
    /**
     * @description 假期类型的标识。
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description 操作者的userId。
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 用户id。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'leaveCode' => 'leaveCode',
        'opUserId'  => 'opUserId',
        'userId'    => 'userId',
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
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InitAndGetLeaveALlocationQuotasRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
