<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateMiniAppPluginResponseBody extends Model
{
    /**
     * @description result
     *
     * @var string
     */
    public $miniAppId;
    protected $_name = [
        'miniAppId' => 'miniAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMiniAppPluginResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }

        return $model;
    }
}
