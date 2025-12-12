<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SendRealAuthInviteMessageResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $hadInvitedNum;

    /**
     * @var int
     */
    public $hadRealAuthNum;

    /**
     * @var int
     */
    public $successNum;
    protected $_name = [
        'hadInvitedNum' => 'hadInvitedNum',
        'hadRealAuthNum' => 'hadRealAuthNum',
        'successNum' => 'successNum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hadInvitedNum) {
            $res['hadInvitedNum'] = $this->hadInvitedNum;
        }
        if (null !== $this->hadRealAuthNum) {
            $res['hadRealAuthNum'] = $this->hadRealAuthNum;
        }
        if (null !== $this->successNum) {
            $res['successNum'] = $this->successNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hadInvitedNum'])) {
            $model->hadInvitedNum = $map['hadInvitedNum'];
        }
        if (isset($map['hadRealAuthNum'])) {
            $model->hadRealAuthNum = $map['hadRealAuthNum'];
        }
        if (isset($map['successNum'])) {
            $model->successNum = $map['successNum'];
        }

        return $model;
    }
}
