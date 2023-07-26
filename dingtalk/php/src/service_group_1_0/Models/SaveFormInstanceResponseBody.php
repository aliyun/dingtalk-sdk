<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveFormInstanceResponseBody extends Model
{
    /**
     * @example 99999
     *
     * @var string
     */
    public $openContactId;

    /**
     * @example 88888
     *
     * @var string
     */
    public $openCustomerId;
    protected $_name = [
        'openContactId'  => 'openContactId',
        'openCustomerId' => 'openCustomerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openContactId) {
            $res['openContactId'] = $this->openContactId;
        }
        if (null !== $this->openCustomerId) {
            $res['openCustomerId'] = $this->openCustomerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveFormInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openContactId'])) {
            $model->openContactId = $map['openContactId'];
        }
        if (isset($map['openCustomerId'])) {
            $model->openCustomerId = $map['openCustomerId'];
        }

        return $model;
    }
}
