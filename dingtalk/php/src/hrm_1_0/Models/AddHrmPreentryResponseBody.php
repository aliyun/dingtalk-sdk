<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddHrmPreentryResponseBody extends Model
{
    /**
     * @description result
     *
     * @var string
     */
    public $tmpUserId;
    protected $_name = [
        'tmpUserId' => 'tmpUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tmpUserId) {
            $res['tmpUserId'] = $this->tmpUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddHrmPreentryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tmpUserId'])) {
            $model->tmpUserId = $map['tmpUserId'];
        }

        return $model;
    }
}
