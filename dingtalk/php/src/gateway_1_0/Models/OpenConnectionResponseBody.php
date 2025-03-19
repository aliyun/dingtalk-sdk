<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenConnectionResponseBody extends Model
{
    /**
     * @example wss://open-connection.dingtalk.com/connect
     *
     * @var string
     */
    public $endpoint;

    /**
     * @example 67e5aeb3-de99-11ed-897e-e251245ed5d2
     *
     * @var string
     */
    public $ticket;
    protected $_name = [
        'endpoint' => 'endpoint',
        'ticket' => 'ticket',
    ];

    public function validate() {}

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
