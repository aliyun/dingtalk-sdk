<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAutoLoginUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example https://meeting.dingtalk.com/j/xxxx
     *
     * @var string
     */
    public $meetingUrl;

    /**
     * @description This parameter is required.
     *
     * @example qzR1iSMDvzR9iPXXXXXXXXXXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'meetingUrl' => 'meetingUrl',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->meetingUrl) {
            $res['meetingUrl'] = $this->meetingUrl;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAutoLoginUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['meetingUrl'])) {
            $model->meetingUrl = $map['meetingUrl'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
