<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatFormGetDataForApiAccessRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $dingTalkTraceId;
    protected $_name = [
        'dingTalkTraceId' => 'dingTalkTraceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTalkTraceId) {
            $res['dingTalkTraceId'] = $this->dingTalkTraceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatFormGetDataForApiAccessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTalkTraceId'])) {
            $model->dingTalkTraceId = $map['dingTalkTraceId'];
        }

        return $model;
    }
}
