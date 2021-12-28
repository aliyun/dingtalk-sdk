<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BindSystemResponseBody extends Model
{
    /**
     * @description 钉钉物联组织ID。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 三方平台的用户ID。
     *
     * @var string
     */
    public $clientId;
    protected $_name = [
        'corpId'   => 'corpId',
        'clientId' => 'clientId',
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
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }

        return $model;
    }
}
