<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $openPushId;
    protected $_name = [
        'openPushId' => 'openPushId',
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
        if (isset($map['openPushId'])) {
            $model->openPushId = $map['openPushId'];
        }

        return $model;
    }
}
