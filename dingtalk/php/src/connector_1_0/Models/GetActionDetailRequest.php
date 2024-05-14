<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetActionDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P
     *
     * @var string
     */
    public $connectAssetUri;
    protected $_name = [
        'connectAssetUri' => 'connectAssetUri',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->connectAssetUri) {
            $res['connectAssetUri'] = $this->connectAssetUri;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetActionDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['connectAssetUri'])) {
            $model->connectAssetUri = $map['connectAssetUri'];
        }

        return $model;
    }
}
