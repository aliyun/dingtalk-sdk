<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountOTOMessageResultRequest extends Model
{
    /**
     * @var string
     */
    public $accountId;

    /**
     * @description 推送ID
     *
     * @var string
     */
    public $openPushId;
    protected $_name = [
        'accountId'  => 'accountId',
        'openPushId' => 'openPushId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->openPushId) {
            $res['openPushId'] = $this->openPushId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountOTOMessageResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['openPushId'])) {
            $model->openPushId = $map['openPushId'];
        }

        return $model;
    }
}
