<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateJsapiTicketResponseBody extends Model
{
    /**
     * @description 超时时间
     *
     * @var int
     */
    public $expireIn;

    /**
     * @description jsapi ticket
     *
     * @var string
     */
    public $jsapiTicket;
    protected $_name = [
        'expireIn'    => 'expireIn',
        'jsapiTicket' => 'jsapiTicket',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expireIn) {
            $res['expireIn'] = $this->expireIn;
        }
        if (null !== $this->jsapiTicket) {
            $res['jsapiTicket'] = $this->jsapiTicket;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateJsapiTicketResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expireIn'])) {
            $model->expireIn = $map['expireIn'];
        }
        if (isset($map['jsapiTicket'])) {
            $model->jsapiTicket = $map['jsapiTicket'];
        }

        return $model;
    }
}
