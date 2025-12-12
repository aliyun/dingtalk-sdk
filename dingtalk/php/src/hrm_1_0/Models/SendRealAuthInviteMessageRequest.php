<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SendRealAuthInviteMessageRequest\onWorkingEmpSearchVO;
use AlibabaCloud\Tea\Model;

class SendRealAuthInviteMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $inviterId;

    /**
     * @description This parameter is required.
     *
     * @var onWorkingEmpSearchVO
     */
    public $onWorkingEmpSearchVO;
    protected $_name = [
        'inviterId' => 'inviterId',
        'onWorkingEmpSearchVO' => 'onWorkingEmpSearchVO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->inviterId) {
            $res['inviterId'] = $this->inviterId;
        }
        if (null !== $this->onWorkingEmpSearchVO) {
            $res['onWorkingEmpSearchVO'] = null !== $this->onWorkingEmpSearchVO ? $this->onWorkingEmpSearchVO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRealAuthInviteMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inviterId'])) {
            $model->inviterId = $map['inviterId'];
        }
        if (isset($map['onWorkingEmpSearchVO'])) {
            $model->onWorkingEmpSearchVO = onWorkingEmpSearchVO::fromMap($map['onWorkingEmpSearchVO']);
        }

        return $model;
    }
}
