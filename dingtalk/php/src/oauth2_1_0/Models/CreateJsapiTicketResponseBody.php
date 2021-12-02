<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateJsapiTicketResponseBody extends Model
{
    /**
     * @description jsapi ticket
     *
     * @var string
     */
    public $jsapiTicket;

    /**
     * @description 超时时间
     *
     * @var int
     */
    public $expireIn;
    protected $_name = [
        'jsapiTicket' => 'jsapiTicket',
        'expireIn'    => 'expireIn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jsapiTicket) {
            $res['jsapiTicket'] = $this->jsapiTicket;
        }
        if (null !== $this->expireIn) {
            $res['expireIn'] = $this->expireIn;
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
        if (isset($map['jsapiTicket'])) {
            $model->jsapiTicket = $map['jsapiTicket'];
        }
        if (isset($map['expireIn'])) {
            $model->expireIn = $map['expireIn'];
        }

        return $model;
    }
}
