<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class EsignQueryIdentityByTicketRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingd0c871e2dfc941a34ac5d6980864d335
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @example feb4b8e5-d6d9-4d22-a6b8-c8e26823a73a
     *
     * @var string
     */
    public $ticket;
    protected $_name = [
        'corpId'    => 'corpId',
        'extension' => 'extension',
        'ticket'    => 'ticket',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->ticket) {
            $res['ticket'] = $this->ticket;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EsignQueryIdentityByTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['ticket'])) {
            $model->ticket = $map['ticket'];
        }

        return $model;
    }
}
