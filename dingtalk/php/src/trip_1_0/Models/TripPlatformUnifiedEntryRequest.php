<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class TripPlatformUnifiedEntryRequest extends Model
{
    /**
     * @example {"projects":[{"thirdId":"00001","number":"00001","scope":1,"action":0,"name":"总务01项目"}]}
     *
     * @var string
     */
    public $messages;

    /**
     * @example partner_syncProject
     *
     * @var string
     */
    public $method;
    protected $_name = [
        'messages' => 'messages',
        'method'   => 'method',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messages) {
            $res['messages'] = $this->messages;
        }
        if (null !== $this->method) {
            $res['method'] = $this->method;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TripPlatformUnifiedEntryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messages'])) {
            $model->messages = $map['messages'];
        }
        if (isset($map['method'])) {
            $model->method = $map['method'];
        }

        return $model;
    }
}
