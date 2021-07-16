<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountOTOMessageResultRequest extends Model
{
    /**
     * @description 推送ID
     *
     * @var string
     */
    public $openPushId;

    /**
     * @var string
     */
    public $accountId;
    protected $_name = [
        'openPushId' => 'openPushId',
        'accountId'  => 'accountId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openPushId) {
            $res['openPushId'] = $this->openPushId;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
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
        if (isset($map['openPushId'])) {
            $model->openPushId = $map['openPushId'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }

        return $model;
    }
}
