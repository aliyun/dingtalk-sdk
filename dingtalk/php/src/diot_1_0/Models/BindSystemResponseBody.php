<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BindSystemResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example d12345
     *
     * @var string
     */
    public $clientId;

    /**
     * @description This parameter is required.
     *
     * @example ding12345
     *
     * @var string
     */
    public $corpId;
    protected $_name = [
        'clientId' => 'clientId',
        'corpId'   => 'corpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BindSystemResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
