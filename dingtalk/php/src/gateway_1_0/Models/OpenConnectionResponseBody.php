<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenConnectionResponseBody extends Model
{
    /**
     * @description 长连接接入点
     *
     * @var string
     */
    public $endpoint;

    /**
     * @description 连接ticket
     *
     * @var string
     */
    public $ticket;
    protected $_name = [
        'endpoint' => 'endpoint',
        'ticket'   => 'ticket',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endpoint) {
            $res['endpoint'] = $this->endpoint;
        }
        if (null !== $this->ticket) {
            $res['ticket'] = $this->ticket;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenConnectionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['ticket'])) {
            $model->ticket = $map['ticket'];
        }

        return $model;
    }
}
